namespace System.Windows.Forms
{
    internal class DataGridViewDoubleBuffered : DataGridView
    {
        public DataGridViewDoubleBuffered()
        {
            this.DoubleBuffered = true;
        }
    }
}