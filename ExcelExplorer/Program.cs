using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Form form = new Form
        {
            Text = "Explorador de Arquivos",
            Width = 400,
            Height = 300
        };

        Button button = new Button
        {
            Text = "Abrir Arquivo",
            Width = 120,
            Height = 40,
            Location = new System.Drawing.Point(140, 120)
        };
        form.Controls.Add(button);

        button.Click += (sender, e) =>
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione um Arquivo",
                Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Arquivo selecionado: {openFileDialog.FileName}");
            }
        };

        Application.Run(form);
    }
}
