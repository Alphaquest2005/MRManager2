using System.Collections.Generic;
using Interfaces;
using RevolutionData;
using ViewModel.Interfaces;


namespace ViewModel.WorkFlow
{
    public class ProcessViewModels
    {
        public static readonly List<IViewModelInfo> ProcessViewModelInfos = new List<IViewModelInfo>
        {
            MainWindowViewModelInfo.MainWindowViewModel,
            ScreenViewModelInfo.ScreenViewModel,
            
            HeaderViewModelInfo.HeaderViewModel,
            FooterViewModelInfo.FooterViewModel,
           
          

        };

        public static readonly List<IViewModelInfo> ProcessCache = new List<IViewModelInfo>
        {
            


        };
    }


}
