using MVVMTraining.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTraining.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        private string _nameArticle = "It`s good )";
        /// <summary>
        /// Название приложения
        /// </summary>
        public string NameArticle
        {
            get => _nameArticle;
            set => Set(ref _nameArticle, value);
        }

        private int _number;
        public int Number
        {
            get => _number;
            set => Set(ref _number, value);
        }

    }
}
