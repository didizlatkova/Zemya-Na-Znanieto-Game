using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Golodnor01
{
    public class Methods
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public PrivateFontCollection myFont = new PrivateFontCollection();        


        // Activate font
        public void EmbedFont()
        {
            unsafe
            {
                fixed (byte* pFontData = Properties.Resources.Bookman_Old_Style)
                {
                    uint dummy = 0;
                    myFont.AddMemoryFont((IntPtr)pFontData, Properties.Resources.Bookman_Old_Style.Length);
                    AddFontMemResourceEx((IntPtr)pFontData, (uint)Properties.Resources.Bookman_Old_Style.Length, IntPtr.Zero, ref dummy);
                }
            }
        }

        // Check if program has to be closed
        public bool Exit()
        {
            Forms.formExit.ShowDialog();
            return GlobalVars.isClosed;
        }

        // Check if user is buying hint
        public bool isBuying()
        {
            Forms.formHintBuy.ShowDialog();
            return GlobalVars.isBuying;
        }

        // Show appropriate message
        public void ShowMessage(string message)
        {
            Forms.formHintMessage.labelHintMessage.Text = message;
            Forms.formHintMessage.ShowDialog();
        }

        // Buy hint
        public void Buy(Control hintShop, Control hintQuestion, int coins)
        {
            hintShop.Visible = false;
            hintQuestion.Visible = true;
            GlobalVars.coins -= coins;
            Forms.formShop.labelCoins.Text = GlobalVars.coins.ToString();
        }

        // Restart game
        public void Restart()
        {
            GlobalVars.isNotMainFirstLoad = false;
            GlobalVars.coins = 0;
            GlobalVars.isBonusQuestion = false;
            GlobalVars.isBuying = false;
            GlobalVars.isGameStarted = false;
            GlobalVars.isHintFiftyBought = false;
            GlobalVars.isHintHeartBought = true;
            GlobalVars.isHintJumpBought = false;
            GlobalVars.isHintOneBought = false;
            GlobalVars.isNotMapFirstLoad = false;
            GlobalVars.isNotQuestionFirstLoad = false;
            GlobalVars.isNotShopFirstLoad = false;
            GlobalVars.isNotHangmanFirstLoad = false;
            GlobalVars.isNotEscapeFirstLoad = false;
            GlobalVars.isQuestion = true;
            GlobalVars.numberGame = 0;
            GlobalVars.numberHearts = 3;
            GlobalVars.numberLevel = 1;
            GlobalVars.numberQuestion = 0;
        }
    }
}
