

namespace michele.natale.Games;

public partial class LittleGame
{
  public void Start(FrmMain? frmmain)
  {
    StartCreateInput();
    using var frm = frmmain;
    frm!.LittleGameHandler += App_LittleGame!;
    frm!.ShowDialog();

    this.Clear();
  }
}