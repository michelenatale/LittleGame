namespace FrmLittleGame;

public partial class UcMain : UserControl
{
  internal void SetRunTlp() => this.SetTlpButtons(1);
  internal void SetStartTlp() => this.SetTlpButtons(0);

  private TableLayoutPanel[] CacheTlp = Array.Empty<TableLayoutPanel>();

  public UcMain()
  {
    this.InitializeComponent();
    this.NewTlpButtons();
    this.SetStartTlp(); 

    this.DgvMain.RowTemplate.Resizable = DataGridViewTriState.True;
    this.DgvMain.RowTemplate.MinimumHeight = this.DgvMain.Height / 4;
    this.DgvMain.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
    this.DgvMain.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.DgvMain.RowsAdded += new DataGridViewRowsAddedEventHandler(this.DgvMain_RowsAdded!);
   } 

  private void DgvMain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
  {
    this.DgvMain.Rows[e.RowIndex].Height = this.DgvMain.Height / 4;
  }

  private void NewTlpButtons()
  {
    this.TblButtons?.Dispose();
    this.CacheTlp = new TableLayoutPanel[] { NewTlpButtonsStart(), NewTlpButtonsYesNo() };
  }

  private void SetTlpButtons(int index)
  {
    this.TblButtons?.SuspendLayout();
    this.SuspendLayout();

    this.TblUcMain.Controls.Remove(this.TblButtons);
    this.TblButtons = this.CacheTlp[index];

    this.TblUcMain.Controls.Add(this.TblButtons, 0, 1);
    this.TblButtons.Dock = DockStyle.Fill;

    this.TblButtons?.ResumeLayout(false);
    this.ResumeLayout(false);
  }



  private TableLayoutPanel NewTlpButtonsYesNo()
  {
    var tlp = new TableLayoutPanel { ColumnCount = 2 };
    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    tlp.Controls.Add(this.BtNo, 1, 0);
    tlp.Controls.Add(this.BtYes, 0, 0);
    tlp.Dock = DockStyle.Fill;
    tlp.Location = new Point(5, 319);
    tlp.Margin = new Padding(5, 4, 5, 4);
    tlp.Name = "TlpButtonsYesNo";
    tlp.RowCount = 1;
    tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
    tlp.Size = new Size(290, 42);
    tlp.TabIndex = 1;
    return tlp;
  }

  private TableLayoutPanel NewTlpButtonsStart()
  {
    var tlp = new TableLayoutPanel { ColumnCount = 1 };
    tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
    tlp.Controls.Add(this.BtStart, 0, 0);
    tlp.Dock = DockStyle.Fill;
    tlp.Location = new Point(5, 319);
    tlp.Margin = new Padding(5, 4, 5, 4);
    tlp.Name = "TlpButtonsStart";
    tlp.RowCount = 1;
    tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
    tlp.Size = new Size(290, 42);
    tlp.TabIndex = 1;
    return tlp;
  }
}
