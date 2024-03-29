using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace Portfolio.Catalog.App.Core.ViewModels
{
    public abstract class BaseViewModel<TParameter> : BaseViewModel, IMvxViewModel<TParameter>
        where TParameter : notnull
    {
        public abstract void Prepare(TParameter parameter);
    }
}
