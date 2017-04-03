﻿using SystemInterfaces;

namespace ViewModel.Interfaces
{
    
    public interface IViewModelLoaded<out TLoadingViewModel, TViewModel> : IProcessSystemMessage, IViewModelEvent<TViewModel>
    {
        TLoadingViewModel LoadingViewModel { get; }
        TViewModel ViewModel { get; }
    }
}
