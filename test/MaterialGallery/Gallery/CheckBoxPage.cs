using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class CheckboxPage : BaseGalleryPage
    {
        public override string Name => "Checkbox Gallery";

        public override ProfileType SupportProfile => ProfileType.Mobile | ProfileType.Wearable;

        public override EvasObject CreateContent(EvasObject parent)
        {
            var box = new ColoredBox(parent);
            box.Show();

            Box horizontalBox = new Box(parent)
            {
                IsHorizontal = true,
                WeightY = 1,
                WeightX = 1,
                AlignmentX = -1,
                AlignmentY = -1
            };
            horizontalBox.Show();

            var check = new MCheckBox(parent)
            {
                IsChecked = true,
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.9,
                AlignmentX = 0.9
            };
            horizontalBox.PackEnd(check);
            check.Show();

            var check2 = new MCheckBox(parent)
            {
                IsEnabled = true,
                Color = Color.FromHex("#E30425"),
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.9,
                AlignmentX = 0.1
            };
            horizontalBox.PackEnd(check2);
            check2.Show();

            Box horizontalBox2 = new Box(parent)
            {
                IsHorizontal = true,
                WeightY = 1,
                WeightX = 1,
                AlignmentX = -1,
                AlignmentY = -1
            };
            horizontalBox2.Show();

            var check3 = new MCheckBox(parent)
            {
                IsEnabled = false,
                IsChecked = false,
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.1,
                AlignmentX = 0.9
            };
            horizontalBox2.PackEnd(check3);
            check3.Show();

            var check4 = new MCheckBox(parent)
            {
                IsEnabled = false,
                IsChecked = true,
                Color = Color.FromHex("#E30425"),
                WeightY = 1,
                WeightX = 1,
                AlignmentY = 0.1,
                AlignmentX = 0.1
            };
            horizontalBox2.PackEnd(check4);
            check4.Show();

            box.PackEnd(horizontalBox);
            box.PackEnd(horizontalBox2);

            return box;
        }
    }
}
