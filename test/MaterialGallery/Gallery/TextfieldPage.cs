using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class TextFieldPage : BaseGalleryPage
    {
        public override string Name => "TextFieldPage";

        public override void Run(Window window)
        {
            Conformant conformant = new Conformant(window);
            conformant.Show();
            Box box = new ColoredBox(window);
            conformant.SetContent(box);
            box.Show();

            var textfield = new MTextField(window)
            {
                Label = "Label",
                Text = "Input text",
                AlignmentX = 0.5,
                AlignmentY = 0.5,
                WeightX = 1,
                WeightY = 1,
                MinimumWidth = 200
            };
            textfield.Show();
            box.PackEnd(textfield);

        }
    }

    // Also, Can define custom color code
    public class MyColorScheme : MColors
    {
        public override Color PrimaryColor => Color.FromHex("#555555");
    }
}
