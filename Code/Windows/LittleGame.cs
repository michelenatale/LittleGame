

namespace michele.natale.Games;

public partial class LittleGame
{
  public void Start(FrmMain? frmmain)
  {
    Start();
    using var frm = frmmain;
    frm!.LittleGameHandler += App_LittleGame!;
    frm!.ShowDialog();
  }
}