using System;
using System.Threading.Tasks;
using E3Framework.Contracts.Interfaces;
using E3Framework.Exceptions;

namespace E3Framework.Abstractions;

public abstract class ComponentAbstract<T> : IComponentBase<T>, IReferenceRecipient
{
    public event ReferenceHandler.ReferenceRequestedHandler? ReferenceRequested;
    public T Instance { get; set; }
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


}