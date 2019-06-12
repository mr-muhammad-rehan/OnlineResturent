using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OnlineResturent.ViewModel
{
    public class ItemVM
    {
        public ObservableCollection<AddOn> AddOns { get; set; }
        public ItemVM()
        {
            AddOns = new ObservableCollection<AddOn>()
            {
                new AddOn{Name="Clasic Falafel ", Description="", Price="19", ImageUrl="https://i.ibb.co/sPbSPf6/operation-falafel-cl-Ns-E00.jpg"},
                new AddOn{Name="Spicy foul", Description="", Price="22", ImageUrl="https://i.ibb.co/3YVvy8V/operation-falafel-fo-TSyfb.jpg"},
                new AddOn{Name="Moutabal", Description="", Price="23", ImageUrl="https://i.ibb.co/hYV7Xms/operation-falafel-hu-8-KVTS.jpg"},

            };
        }

        public class AddOn
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
            public string ImageUrl { get; set; }

        }
    }
}
