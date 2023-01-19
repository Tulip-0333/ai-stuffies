using System;
using System.Windows.Forms;

class SimpleWindow : Form
{
    public SimpleWindow()
    {
        // Create the button
        var button = new Button
        {
            Text = "Add time",
            Location = new System.Drawing.Point(50, 50),
        };
        button.Click += new EventHandler(ButtonClick);

        // Create the listbox
        var listBox = new ListBox
        {
            Location = new System.Drawing.Point(50, 100),
        };

        // Add the button and listbox to the form
        this.Controls.Add(button);
        this.Controls.Add(listBox);
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        ListBox listBox = (ListBox)this.Controls["listBox1"];
        listBox.Items.Add(DateTime.Now.ToString());
    }

    public static void Main()
    {
        Application.Run(new SimpleWindow());
    }
}
