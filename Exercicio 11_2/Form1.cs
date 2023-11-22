namespace Exercicio_11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cor = new ColorDialog();
            if (cor.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = cor.Color;
            }
            FontDialog letra = new FontDialog();
            if (letra.ShowDialog() == DialogResult.OK)
            {
                label1.Font = letra.Font;
            }
        }
    }
}