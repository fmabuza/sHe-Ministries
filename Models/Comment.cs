using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace sHe_Ministries.Models
{
    [RunInstaller(true)]
    public partial class Comment : System.Configuration.Install.Installer
    {
        public Comment()
        {
            InitializeComponent();
        }
    }
}
