

namespace michele.natale.Games;


public partial class FrmMain : Form
{
  private int Sum = 0;
  private int Index = 0;
  private List<int[]> Data = Array.Empty<int[]>().ToList();

  private void Buttons_Click(object sender, EventArgs e)
  {
    switch (sender)
    {
      case Button obj when obj == this.BtClose: this.CloseForm(); break;
      case Button obj when obj == this.UcMainRun.BtNo: this.Run(false); break;
      case Button obj when obj == this.UcMainRun.BtYes: this.Run(true); break;
      case Button obj when obj == this.UcMainRun.BtStart: Start(); break;
    }
  }

  private void CloseForm() => this.Close();

  private void Start()
  {
    this.UcMainRun.SetRunTlp();
    this.LoadNewGame();

    this.Sum = 0;
    this.Index = 1;
  }

  private void Run(bool answer)
  {
    if (this.Index == 0 && !answer)
      this.CloseForm();

    if (this.Index == 0)
    {
      this.Start();
      return;
    }

    if (answer)
      this.Sum += this.Data[this.Index - 1].Min();

    if (this.Index > 5)
    {
      MessageBox.Show($"Your Number is {this.Sum}", "Result");

      this.UcMainRun.DgvMain.Rows.Clear();

      this.TsslText.Text = $"      Another round?";
      this.Index = 0;
      return;
    }

    this.NextData();
    this.Index++;
  }

  private void LoadNewGame()
  {
    this.Data = LittleGame.Data.ToList();
    this.NextData();
  }

  private void NextData()
  {
    this.UcMainRun.DgvMain.Rows.Clear();
    var list = ToTable();
    var columns = list.Max(x => x.Length);
    this.UcMainRun.DgvMain.ColumnCount = columns;
    Array.ForEach(list, x => this.UcMainRun.DgvMain.Rows.Add(x));
    this.TsslText.Text = "      Is the number in this table?";
  }

  private string[][] ToTable()
  {
    var data = this.Data[this.Index];
    var result = Enumerable.Range(0, 4).Select(x => new string[8]).ToList();
    for (var i = 0; i < 4; i++)
      for (var j = 0; j < 8; j++)
        result[i][j] = this.Data[this.Index][i * 8 + j].ToString();
    return result.Select(str => str).ToArray();
  }

  public FrmMain()
  {
    this.InitializeComponent();
    LittleGame.Start();

    this.UcMainRun.BtNo.Click += new EventHandler(this.Buttons_Click!);
    this.UcMainRun.BtYes.Click += new EventHandler(this.Buttons_Click!);
    this.UcMainRun.BtStart.Click += new EventHandler(this.Buttons_Click!);
  }
}
