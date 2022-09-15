namespace FirstWindows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void chbMilliKilometr_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMilliKilometr.Checked)
                chbMilliKilometr.Text = "���������->�����";
            else
                chbMilliKilometr.Text = "�����->���������";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try 
            {
                double milli, kilometr;
                if (chbMilliKilometr.Checked)
                {
                    kilometr = double.Parse(txtMilliKilometers.Text);
                    milli = kilometr/1.86;
                    lbResult.Text = $"{kilometr} ��={milli:F2} ����";
                }
                else
                {
                    milli = double.Parse(txtMilliKilometers.Text);
                    kilometr = milli * 1.86;
                    lbResult.Text = $"{milli} ����={kilometr:F2} ��";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMilliKilometers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if(e.KeyChar==',')
            {
                if(txtMilliKilometers.Text.IndexOf(',')!=-1)
                {
                    e.Handled = true;
                }
                return;
            }
            if(Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}