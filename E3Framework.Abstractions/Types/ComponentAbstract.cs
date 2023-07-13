using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using E3Framework.Abstractions.ProxyClasses;
using E3Framework.Contracts.Interfaces;
using E3Framework.Exceptions;

namespace E3Framework.Abstractions.Types;

public abstract class ComponentAbstract<T> : ProxyBase<T>, IReferenceRecipient, IIdentifiable
{
    public event ReferenceHandler.ReferenceRequestedHandler? ReferenceRequested;
    public int Id { get; set; }
    
    #region Instance Behaviors
    
    // Method calls to ensure on child class init to always has from container at least a new instance of E3 interface from Ioc container
    // 
    public virtual async Task Init()
    {
        if (Ensure() && AlwaysRenewInstance)
        {
            await RequireAsync<T>();
        }
    }

    protected void Require<T>()
    {
        ReferenceRequested?.Invoke(this,typeof(T));
    }

    private bool Ensure()
    {
        bool isValid = false;
        try
        {
            if (InstanceRequired && this.Instance == null)
            {
                throw new InstanceUndefinedException();
            }

            if (!InstanceRequired) isValid = true;
        }
        catch (InstanceUndefinedException ex)
        {
            isValid = false;

            throw new InstanceUndefinedException($"Cannot create class object of type  {this.GetType()}." +
                                                 $"The Parameter {nameof(InstanceRequired)} is defined but the {typeof(T)} instance is null/undefined.", ex);
        }
        return isValid;
    }

    protected async Task RequireAsync<T>()
    {
        await Task.Factory.StartNew(() => this.Require<T>());
    }

    protected bool AlwaysRenewInstance { get; set; } = true;

    protected bool InstanceRequired { get; private set; } = true;

    #endregion

    public ComponentAbstract() : base()
    {
        
    }
    public new void Dispose()
    {
        try
        {
            if (this.Instance is { })
            {
                Marshal.ReleaseComObject(this.Instance);
            }
        }
        catch (ArgumentException argEx)
        {
            throw new ArgumentException($"Cannot release {nameof(this.Instance)} reference. The specified reference is not a valid COM interop object.");
        }
        catch (NullReferenceException nullEx)
        {
            throw new InstanceUndefinedException($"The {nameof(this.Instance)} is already discarded");
        }
        finally
        {
            this.Instance = default;
            GC.SuppressFinalize(this);
        }
        
    }

    public T Instance { get; set; }
}