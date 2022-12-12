using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Учебный_план.Models;
using Учебный_план.Tools;

namespace Учебный_план.ViewModels
{
    internal class GroupListPageVM:BaseVM
    {
        private MainWindowVM MainWindowVM;
        private List<Group> groups;
        public GroupListPageVM(MainWindowVM mainWindowVM)
        {
            MainWindowVM = mainWindowVM;
            Groups = DB.user30Context.GetInstance().Groups.ToList();
        }
        public List<Group> Groups
        {
            get => groups;
            set
            {
                groups = value;
                SignalChanged();
            }

        }
    }
}
