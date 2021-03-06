﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigAz.Azure.UserControls
{
    public class TargetPropertyControl : UserControl
    {
        public delegate Task AfterPropertyChanged();
        public event AfterPropertyChanged PropertyChanged;

        internal TargetTreeView _TargetTreeView;
        private bool _IsBinding = false;

        internal bool IsBinding
        {
            get { return _IsBinding; }
            set { _IsBinding = value; }
        }

        internal void RaisePropertyChangedEvent()
        {
            if (!this.IsBinding)
                PropertyChanged?.Invoke();
        }

        internal virtual void UpdatePropertyEnablement() { }
    }
}
