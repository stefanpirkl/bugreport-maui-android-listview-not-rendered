using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewVisibleBug
{
    public class MainPageViewModel : BindableObject
    {
        private List<ListData> _list1Data = new List<ListData> {
            new ListData{ Text = "List 1 - Item 1" },
            new ListData{ Text = "List 1 - Item 2" },
            new ListData{ Text = "List 1 - Item 3" }
            };
        private List<ListData> _list2Data = new List<ListData> {
            new ListData{ Text = "List 2 - Item 1" },
            new ListData{ Text = "List 2 - Item 2" },
            new ListData{ Text = "List 2 - Item 3" }
            };
        private bool _list1Visible = true;
        private bool _list2Visible = false;

        public List<ListData> List1Data
        {
            get { return _list1Data; }
            set { _list1Data = value; OnPropertyChanged(nameof(List1Data)); }
        }
        public List<ListData> List2Data
        {
            get { return _list2Data; }
            set { _list2Data = value; OnPropertyChanged(nameof(List2Data)); }
        }
        public bool List1Visible
        {
            get { return _list1Visible; }
            set { _list1Visible = value; OnPropertyChanged(nameof(List1Visible)); }
        }
        public bool List2Visible
        {
            get { return _list2Visible; }
            set { _list2Visible = value; OnPropertyChanged(nameof(List2Visible)); }
        }

        public void Button_Clicked()
        {
            if (_list1Visible)
            {
                List1Visible = false;
                List2Visible = true;
            }
            else
            {
                List1Visible = true;
                List2Visible = false;
            }
        }
    }
}
