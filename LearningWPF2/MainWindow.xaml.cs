using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace LearningWPF2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new DirectoryStructureViewModel();

            /* var d = new DirectoryStructureViewModel();
            var item1 = d.Items[0];

            d.Items[0].ExpandCommand.Execute(null); */

            /* пример, чтобы посмотреть, что такое HeaderTemplate (см. описание, появляющееся после точки) 
             var t = new TreeViewItem();
            t.HeaderTemplate
            */
        }
        #endregion
        
    }
}
