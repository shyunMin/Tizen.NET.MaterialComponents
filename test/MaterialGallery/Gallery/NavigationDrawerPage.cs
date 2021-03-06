using ElmSharp;
using System.Collections.Generic;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class NavigationDrawerPage : BaseGalleryPage
    {
        public override string Name => "NavigationDrawerPage Gallery";

        public override bool RunningOnNewWindow => true;

        public override EvasObject CreateContent(EvasObject parent)
        {
            Box box = new ColoredBox(parent);
            box.Show();

            MNavigationView nv = new MNavigationView(parent);

            var paddingbox = new Box(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                MinimumWidth = 32,
            };
            paddingbox.Show();
            var paddingbox1 = new Box(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                MinimumWidth = 32,
            };
            paddingbox1.Show();
            var paddingbox2 = new Box(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                MinimumHeight = 30,
            };
            paddingbox2.Show();
            var paddingbox3 = new Box(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                MinimumHeight = 10,
            };
            paddingbox3.Show();

            var name = new Label(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                WeightX = 1,
                WeightY = 1,
                Text = "<span font_weight=bold font_size=50>Tizen</span>",
                MinimumHeight = 80
            };
            name.Show();

            var namebox = new Box(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                WeightX = 1,
                WeightY = 1,
                IsHorizontal = true,
            };
            namebox.Show();
            namebox.PackEnd(paddingbox);
            namebox.PackEnd(name);

            var email = new Label(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                WeightX = 1,
                WeightY = 1,
                Text = "<span font_size=35>tizen@samsung.com<span>",
            };
            email.Show();

            var emailbox = new Box(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                WeightX = 1,
                WeightY = 1,
                IsHorizontal = true,
            };
            emailbox.Show();
            emailbox.PackEnd(paddingbox1);
            emailbox.PackEnd(email);

            var header = new Box(parent)
            {
                MinimumHeight = 200,
                BackgroundColor = Color.White
            };
            header.PackEnd(paddingbox2);
            header.PackEnd(namebox);
            header.PackEnd(emailbox);
            header.PackEnd(paddingbox3);
            header.Show();

            nv.Header = header;

            var items = new List<MItem>();

            items.Add(new MItem("My Files", "icon.png"));
            items.Add(new MItem("Shared with me", "icon.png"));
            items.Add(new MItem("Starred", "icon.png"));
            items.Add(new MItem("Recent", "icon.png"));
            items.Add(new MItem("Offline", "icon.png"));
            items.Add(new MItem("Uploads", "icon.png"));
            items.Add(new MItem("Backup", "icon.png"));
            items.Add(new MItem("Movie", "icon.png"));
            items.Add(new MItem("Music", "icon.png"));
            items.Add(new MItem("Play", "icon.png"));

            nv.Menu = items;

            var main1 = new MButton(parent)
            {
                Text = "Open NavigationView",
                AlignmentX = 0,
                AlignmentY = 0,
                MinimumWidth = 720,
                MinimumHeight = 300
            };
            main1.Show();

            var nd = new MNavigationDrawer(parent)
            {
                AlignmentX = -1,
                AlignmentY = -1,
                WeightX = 1,
                WeightY = 1,
            };

            nd.Main = main1;
            nd.NavigationView = nv;

            main1.Clicked += (s, e) =>
            {
                nd.IsOpen = true;
            };

            nd.Show();

            box.PackEnd(nd);

            return box;
        }

        public override void TearDown()
        {
            base.TearDown();
        }
    }
}
