

namespace michele.natale.Games;

partial class FrmMain
{
  private class TlpHolder
  {
    internal Button BtNo { get; private set; }
    internal Button BtYes { get; private set; }
    internal Button BtStart { get; private set; }

    internal TableLayoutPanel[] CacheTlp { get; private set; } = Array.Empty<TableLayoutPanel>();

    public TlpHolder()
    {
      (Button btno, Button btyes, Button btstart) = CreateNewButtons();
      this.BtNo = btno;
      this.BtYes = btyes;
      this.BtStart = btstart;
      this.CacheTlp = this.NewTlpButtons();
    }

    private static (Button BtNo, Button BtYes, Button BtStart) CreateNewButtons()
    {
      return
        (CreateNewButton("BtNo", "No", 5),
         CreateNewButton("BtYes", "Yes", 4),
         CreateNewButton("BtStart", "Start", 0));
    }

    private static Button CreateNewButton(string name, string text, int tabindex)
    {
      return new Button
      {
        Anchor = AnchorStyles.None,
        Location = new Point(3, 10),
        Name = name,
        Size = new Size(50, 34),
        TabIndex = tabindex,
        Text = text,
        UseVisualStyleBackColor = true,
        Dock = DockStyle.Fill
      };
    }

    private TableLayoutPanel[] NewTlpButtons()
    {
      return new[]
      {
         NewTlpButtons(1,new[]{ 100f},1,new[]{ 100f},new[]{this.BtStart },"TlpButtonsStart",1),
         NewTlpButtons(1,new[]{ 100f},2,new[]{ 50f,50f},new[]{this.BtYes,this.BtNo, },"TlpButtonsYesNo",1),
      };
    }

    private static TableLayoutPanel NewTlpButtons(
      int rowcnt, float[] rowpercent,
      int columncnt, float[] columnpercent,
      Button[] buttons, string name, int tabindex)
    {
      var tlp = new TableLayoutPanel { ColumnCount = columncnt };

      foreach (var prc in columnpercent)
        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, prc));
      //tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      //tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

      for (var i = 0; i < buttons.Length; i++)
        tlp.Controls.Add(buttons[i], i, 0);
      //tlp.Controls.Add(this.BtYes, 0, 0);
      //tlp.Controls.Add(this.BtNo, 1, 0);

      tlp.Dock = DockStyle.Fill;
      tlp.Location = new Point(8, 8);
      tlp.Margin = new Padding(8, 3, 8, 3);
      tlp.Name = name; tlp.RowCount = rowcnt;
      foreach (var prc in rowpercent)
        tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, prc));
      //tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

      tlp.Size = new Size(290, 42);
      tlp.TabIndex = tabindex;
      return tlp;
    }

    //private TableLayoutPanel NewTlpButtonsYesNo(
    //  int rowcnt,float[] rowpercent,
    //  int columncnt, float[] columnpercent,
    //  Button[] buttons, string name, int tabindex)
    //{
    //  var tlp = new TableLayoutPanel { ColumnCount = 2 };
    //  tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    //  tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
    //  tlp.Controls.Add(this.BtNo, 1, 0);
    //  tlp.Controls.Add(this.BtYes, 0, 0);
    //  tlp.Dock = DockStyle.Fill;
    //  tlp.Location = new Point(5, 319);
    //  tlp.Margin = new Padding(5, 4, 5, 4);
    //  tlp.Name = "TlpButtonsYesNo";
    //  tlp.RowCount = 1;
    //  tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
    //  tlp.Size = new Size(290, 42);
    //  tlp.TabIndex = 1;
    //  return tlp;
    //}

    //private TableLayoutPanel NewTlpButtonsStart()
    //{
    //  var tlp = new TableLayoutPanel { ColumnCount = 1 };
    //  tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
    //  tlp.Controls.Add(this.BtStart, 0, 0);
    //  tlp.Dock = DockStyle.Fill;
    //  tlp.Location = new Point(5, 319);
    //  tlp.Margin = new Padding(5, 4, 5, 4);
    //  tlp.Name = "TlpButtonsStart";
    //  tlp.RowCount = 1;
    //  tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
    //  tlp.Size = new Size(290, 42);
    //  tlp.TabIndex = 1;
    //  return tlp;
    //}
  }
}
