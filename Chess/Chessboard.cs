using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Chessboard : Form
    {
        private bool whiteMove = true;
        private string position;
        private string start = "";
        private string type;
        public Chessboard()
        {
            InitializeComponent();
        }

        private void A8_Click(object sender, EventArgs e)
        {
            position = "a8";
            DoMove();
        }

        private void B8_Click(object sender, EventArgs e)
        {
            position = "b8";
            DoMove();
        }

        private void C8_Click(object sender, EventArgs e)
        {
            position = "c8";
            DoMove();
        }

        private void D8_Click(object sender, EventArgs e)
        {
            position = "d8";
            DoMove();
        }

        private void E8_Click(object sender, EventArgs e)
        {
            position = "e8";
            DoMove();
        }

        private void F8_Click(object sender, EventArgs e)
        {
            position = "f8";
            DoMove();
        }

        private void G8_Click(object sender, EventArgs e)
        {
            position = "g8";
            DoMove();
        }

        private void H8_Click(object sender, EventArgs e)
        {
            position = "h8";
            DoMove();
        }

        private void A7_Click(object sender, EventArgs e)
        {
            position = "a7";
            DoMove();
        }

        private void B7_Click(object sender, EventArgs e)
        {
            position = "b7";
            DoMove();
        }

        private void C7_Click(object sender, EventArgs e)
        {
            position = "c7";
            DoMove();
        }

        private void D7_Click(object sender, EventArgs e)
        {
            position = "d7";
            DoMove();
        }

        private void E7_Click(object sender, EventArgs e)
        {
            position = "e7";
            DoMove();
        }

        private void F7_Click(object sender, EventArgs e)
        {
            position = "f7";
            DoMove();
        }

        private void G7_Click(object sender, EventArgs e)
        {
            position = "g7";
            DoMove();
        }

        private void H7_Click(object sender, EventArgs e)
        {
            position = "h7";
            DoMove();
        }

        private void A6_Click(object sender, EventArgs e)
        {
            position = "a6";
            DoMove();
        }

        private void B6_Click(object sender, EventArgs e)
        {
            position = "b6";
            DoMove();
        }

        private void C6_Click(object sender, EventArgs e)
        {
            position = "c6";
            DoMove();
        }

        private void D6_Click(object sender, EventArgs e)
        {
            position = "d6";
            DoMove();
        }

        private void E6_Click(object sender, EventArgs e)
        {
            position = "e6";
            DoMove();
        }

        private void F6_Click(object sender, EventArgs e)
        {
            position = "f6";
            DoMove();
        }

        private void G6_Click(object sender, EventArgs e)
        {
            position = "g6";
            DoMove();
        }

        private void H6_Click(object sender, EventArgs e)
        {
            position = "h6";
            DoMove();
        }

        private void A5_Click(object sender, EventArgs e)
        {
            position = "a5";
            DoMove();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            position = "b5";
            DoMove();
        }

        private void C5_Click(object sender, EventArgs e)
        {
            position = "c5";
            DoMove();
        }

        private void D5_Click(object sender, EventArgs e)
        {
            position = "d5";
            DoMove();
        }

        private void E5_Click(object sender, EventArgs e)
        {
            position = "e5";
            DoMove();
        }

        private void F5_Click(object sender, EventArgs e)
        {
            position = "f5";
            DoMove();
        }

        private void G5_Click(object sender, EventArgs e)
        {
            position = "g5";
            DoMove();
        }

        private void H5_Click(object sender, EventArgs e)
        {
            position = "h5";
            DoMove();
        }

        private void A4_Click(object sender, EventArgs e)
        {
            position = "a4";
            DoMove();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            position = "b4";
            DoMove();
        }

        private void C4_Click(object sender, EventArgs e)
        {
            position = "c4";
            DoMove();
        }

        private void D4_Click(object sender, EventArgs e)
        {
            position = "d4";
            DoMove();
        }

        private void E4_Click(object sender, EventArgs e)
        {
            position = "e4";
            DoMove();
        }

        private void F4_Click(object sender, EventArgs e)
        {
            position = "f4";
            DoMove();
        }

        private void G4_Click(object sender, EventArgs e)
        {
            position = "g4";
            DoMove();
        }

        private void H4_Click(object sender, EventArgs e)
        {
            position = "h4";
            DoMove();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            position = "a3";
            DoMove();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            position = "b3";
            DoMove();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            position = "c3";
            DoMove();
        }

        private void D3_Click(object sender, EventArgs e)
        {
            position = "d3";
            DoMove();
        }

        private void E3_Click(object sender, EventArgs e)
        {
            position = "e3";
            DoMove();
        }

        private void F3_Click(object sender, EventArgs e)
        {
            position = "f3";
            DoMove();
        }

        private void G3_Click(object sender, EventArgs e)
        {
            position = "g3";
            DoMove();
        }

        private void H3_Click(object sender, EventArgs e)
        {
            position = "h3";
            DoMove();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            position = "a2";
            DoMove();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            position = "b2";
            DoMove();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            position = "c2";
            DoMove();
        }

        private void D2_Click(object sender, EventArgs e)
        {
            position = "d2";
            DoMove();
        }

        private void E2_Click(object sender, EventArgs e)
        {
            position = "e2";
            DoMove();
        }

        private void F2_Click(object sender, EventArgs e)
        {
            position = "f2";
            DoMove();
        }

        private void G2_Click(object sender, EventArgs e)
        {
            position = "g2";
            DoMove();
        }

        private void H2_Click(object sender, EventArgs e)
        {
            position = "h2";
            DoMove();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            position = "a1";
            DoMove();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            position = "b1";
            DoMove();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            position = "c1";
            DoMove();
        }

        private void D1_Click(object sender, EventArgs e)
        {
            position = "d1";
            DoMove();
        }

        private void E1_Click(object sender, EventArgs e)
        {
            position = "e1";
            DoMove();
        }

        private void F1_Click(object sender, EventArgs e)
        {
            position = "f1";
            DoMove();
        }

        private void G1_Click(object sender, EventArgs e)
        {
            position = "g1";
            DoMove();
        }

        private void H1_Click(object sender, EventArgs e)
        {
            position = "h1";
            DoMove();
        }
        public void DoMove()
        {
            if (start == "")
            {
                switch (position)
                {
                    case "a1":
                        {
                            if (whiteMove == true)
                            {
                                if (a1.Text == "♔" || a1.Text == "♕" || a1.Text == "♖" || a1.Text == "♗" || a1.Text == "♘" || a1.Text == "♙")             //White
                                {
                                    start = "a1";
                                    type = a1.Text;
                                    a1.Text = "";
                                }
                            }
                            else
                            {
                                if (a1.Text == "♚" || a1.Text == "♛" || a1.Text == "♜" || a1.Text == "♝" || a1.Text == "♞" || a1.Text == "♟")             //Black
                                {
                                    start = "a1";
                                    type = a1.Text;
                                    a1.Text = "";
                                }
                            }
                            break;
                        }
                    case "b1":
                        {
                            if (whiteMove == true)
                            {
                                if (b1.Text == "♔" || b1.Text == "♕" || b1.Text == "♖" || b1.Text == "♗" || b1.Text == "♘" || b1.Text == "♙")             //White
                                {
                                    start = "b1";
                                    type = b1.Text;
                                    b1.Text = "";
                                }
                            }
                            else
                            {
                                if (b1.Text == "♚" || b1.Text == "♛" || b1.Text == "♜" || b1.Text == "♝" || b1.Text == "♞" || b1.Text == "♟")             //Black
                                {
                                    start = "b1";
                                    type = b1.Text;
                                    b1.Text = "";
                                }
                            }
                            break;
                        }
                    case "c1":
                        {
                            if (whiteMove == true)
                            {
                                if (c1.Text == "♔" || c1.Text == "♕" || c1.Text == "♖" || c1.Text == "♗" || c1.Text == "♘" || c1.Text == "♙")             //White
                                {
                                    start = "c1";
                                    type = c1.Text;
                                    c1.Text = "";
                                }
                            }
                            else
                            {
                                if (c1.Text == "♚" || c1.Text == "♛" || c1.Text == "♜" || c1.Text == "♝" || c1.Text == "♞" || c1.Text == "♟")             //Black
                                {
                                    start = "c1";
                                    type = c1.Text;
                                    c1.Text = "";
                                }
                            }
                            break;
                        }
                    case "d1":
                        {
                            if (whiteMove == true)
                            {
                                if (d1.Text == "♔" || d1.Text == "♕" || d1.Text == "♖" || d1.Text == "♗" || d1.Text == "♘" || d1.Text == "♙")             //White
                                {
                                    start = "d1";
                                    type = d1.Text;
                                    d1.Text = "";
                                }
                            }
                            else
                            {
                                if (d1.Text == "♚" || d1.Text == "♛" || d1.Text == "♜" || d1.Text == "♝" || d1.Text == "♞" || d1.Text == "♟")             //Black
                                {
                                    start = "d1";
                                    type = d1.Text;
                                    d1.Text = "";
                                }
                            }
                            break;
                        }
                    case "e1":
                        {
                            if (whiteMove == true)
                            {
                                if (e1.Text == "♔" || e1.Text == "♕" || e1.Text == "♖" || e1.Text == "♗" || e1.Text == "♘" || e1.Text == "♙")             //White
                                {
                                    start = "e1";
                                    type = e1.Text;
                                    e1.Text = "";
                                }
                            }
                            else
                            {
                                if (e1.Text == "♚" || e1.Text == "♛" || e1.Text == "♜" || e1.Text == "♝" || e1.Text == "♞" || e1.Text == "♟")             //Black
                                {
                                    start = "e1";
                                    type = e1.Text;
                                    e1.Text = "";
                                }
                            }
                            break;
                        }
                    case "f1":
                        {
                            if (whiteMove == true)
                            {
                                if (f1.Text == "♔" || f1.Text == "♕" || f1.Text == "♖" || f1.Text == "♗" || f1.Text == "♘" || f1.Text == "♙")             //White
                                {
                                    start = "f1";
                                    type = f1.Text;
                                    f1.Text = "";
                                }
                            }
                            else
                            {
                                if (f1.Text == "♚" || f1.Text == "♛" || f1.Text == "♜" || f1.Text == "♝" || f1.Text == "♞" || f1.Text == "♟")             //Black
                                {
                                    start = "f1";
                                    type = f1.Text;
                                    f1.Text = "";
                                }
                            }
                            break;
                        }
                    case "g1":
                        {
                            if (whiteMove == true)
                            {
                                if (g1.Text == "♔" || g1.Text == "♕" || g1.Text == "♖" || g1.Text == "♗" || g1.Text == "♘" || g1.Text == "♙")             //White
                                {
                                    start = "g1";
                                    type = g1.Text;
                                    g1.Text = "";
                                }
                            }
                            else
                            {
                                if (g1.Text == "♚" || g1.Text == "♛" || g1.Text == "♜" || g1.Text == "♝" || g1.Text == "♞" || g1.Text == "♟")             //Black
                                {
                                    start = "g1";
                                    type = g1.Text;
                                    g1.Text = "";
                                }
                            }
                            break;
                        }
                    case "h1":
                        {
                            if (whiteMove == true)
                            {
                                if (h1.Text == "♔" || h1.Text == "♕" || h1.Text == "♖" || h1.Text == "♗" || h1.Text == "♘" || h1.Text == "♙")             //White
                                {
                                    start = "h1";
                                    type = h1.Text;
                                    h1.Text = "";
                                }
                            }
                            else
                            {
                                if (h1.Text == "♚" || h1.Text == "♛" || h1.Text == "♜" || h1.Text == "♝" || h1.Text == "♞" || h1.Text == "♟")             //Black
                                {
                                    start = "h1";
                                    type = h1.Text;
                                    h1.Text = "";
                                }
                            }
                            break;
                        }
                    case "a2":
                        {
                            if (whiteMove == true)
                            {
                                if (a2.Text == "♔" || a2.Text == "♕" || a2.Text == "♖" || a2.Text == "♗" || a2.Text == "♘" || a2.Text == "♙")             //White
                                {
                                    start = "a2";
                                    type = a2.Text;
                                    a2.Text = "";
                                }
                            }
                            else
                            {
                                if (a2.Text == "♚" || a2.Text == "♛" || a2.Text == "♜" || a2.Text == "♝" || a2.Text == "♞" || a2.Text == "♟")             //Black
                                {
                                    start = "a2";
                                    type = a2.Text;
                                    a2.Text = "";
                                }
                            }
                            break;
                        }
                    case "b2":
                        {
                            if (whiteMove == true)
                            {
                                if (b2.Text == "♔" || b2.Text == "♕" || b2.Text == "♖" || b2.Text == "♗" || b2.Text == "♘" || b2.Text == "♙")             //White
                                {
                                    start = "b2";
                                    type = b2.Text;
                                    b2.Text = "";
                                }
                            }
                            else
                            {
                                if (b2.Text == "♚" || b2.Text == "♛" || b2.Text == "♜" || b2.Text == "♝" || b2.Text == "♞" || b2.Text == "♟")             //Black
                                {
                                    start = "b2";
                                    type = b2.Text;
                                    b2.Text = "";
                                }
                            }
                            break;
                        }
                    case "c2":
                        {
                            if (whiteMove == true)
                            {
                                if (c2.Text == "♔" || c2.Text == "♕" || c2.Text == "♖" || c2.Text == "♗" || c2.Text == "♘" || c2.Text == "♙")             //White
                                {
                                    start = "c2";
                                    type = c2.Text;
                                    c2.Text = "";
                                }
                            }
                            else
                            {
                                if (c2.Text == "♚" || c2.Text == "♛" || c2.Text == "♜" || c2.Text == "♝" || c2.Text == "♞" || c2.Text == "♟")             //Black
                                {
                                    start = "c2";
                                    type = c2.Text;
                                    c2.Text = "";
                                }
                            }
                            break;
                        }
                    case "d2":
                        {
                            if (whiteMove == true)
                            {
                                if (d2.Text == "♔" || d2.Text == "♕" || d2.Text == "♖" || d2.Text == "♗" || d2.Text == "♘" || d2.Text == "♙")             //White
                                {
                                    start = "d2";
                                    type = d2.Text;
                                    d2.Text = "";
                                }
                            }
                            else
                            {
                                if (d2.Text == "♚" || d2.Text == "♛" || d2.Text == "♜" || d2.Text == "♝" || d2.Text == "♞" || d2.Text == "♟")             //Black
                                {
                                    start = "d2";
                                    type = d2.Text;
                                    d2.Text = "";
                                }
                            }
                            break;
                        }
                    case "e2":
                        {
                            if (whiteMove == true)
                            {
                                if (e2.Text == "♔" || e2.Text == "♕" || e2.Text == "♖" || e2.Text == "♗" || e2.Text == "♘" || e2.Text == "♙")             //White
                                {
                                    start = "e2";
                                    type = e2.Text;
                                    e2.Text = "";
                                }
                            }
                            else
                            {
                                if (e2.Text == "♚" || e2.Text == "♛" || e2.Text == "♜" || e2.Text == "♝" || e2.Text == "♞" || e2.Text == "♟")             //Black
                                {
                                    start = "e2";
                                    type = e2.Text;
                                    e2.Text = "";
                                }
                            }
                            break;
                        }
                    case "f2":
                        {
                            if (whiteMove == true)
                            {
                                if (f2.Text == "♔" || f2.Text == "♕" || f2.Text == "♖" || f2.Text == "♗" || f2.Text == "♘" || f2.Text == "♙")             //White
                                {
                                    start = "f2";
                                    type = f2.Text;
                                    f2.Text = "";
                                }
                            }
                            else
                            {
                                if (f2.Text == "♚" || f2.Text == "♛" || f2.Text == "♜" || f2.Text == "♝" || f2.Text == "♞" || f2.Text == "♟")             //Black
                                {
                                    start = "f2";
                                    type = f2.Text;
                                    f2.Text = "";
                                }
                            }
                            break;
                        }
                    case "g2":
                        {
                            if (whiteMove == true)
                            {
                                if (g2.Text == "♔" || g2.Text == "♕" || g2.Text == "♖" || g2.Text == "♗" || g2.Text == "♘" || g2.Text == "♙")             //White
                                {
                                    start = "g2";
                                    type = g2.Text;
                                    g2.Text = "";
                                }
                            }
                            else
                            {
                                if (g2.Text == "♚" || g2.Text == "♛" || g2.Text == "♜" || g2.Text == "♝" || g2.Text == "♞" || g2.Text == "♟")             //Black
                                {
                                    start = "g2";
                                    type = g2.Text;
                                    g2.Text = "";
                                }
                            }
                            break;
                        }
                    case "h2":
                        {
                            if (whiteMove == true)
                            {
                                if (h2.Text == "♔" || h2.Text == "♕" || h2.Text == "♖" || h2.Text == "♗" || h2.Text == "♘" || h2.Text == "♙")             //White
                                {
                                    start = "h2";
                                    type = h2.Text;
                                    h2.Text = "";
                                }
                            }
                            else
                            {
                                if (h2.Text == "♚" || h2.Text == "♛" || h2.Text == "♜" || h2.Text == "♝" || h2.Text == "♞" || h2.Text == "♟")             //Black
                                {
                                    start = "h2";
                                    type = h2.Text;
                                    h2.Text = "";
                                }
                            }
                            break;
                        }
                    case "a3":
                        {
                            if (whiteMove == true)
                            {
                                if (a3.Text == "♔" || a3.Text == "♕" || a3.Text == "♖" || a3.Text == "♗" || a3.Text == "♘" || a3.Text == "♙")             //White
                                {
                                    start = "a3";
                                    type = a3.Text;
                                    a3.Text = "";
                                }
                            }
                            else
                            {
                                if (a3.Text == "♚" || a3.Text == "♛" || a3.Text == "♜" || a3.Text == "♝" || a3.Text == "♞" || a3.Text == "♟")             //Black
                                {
                                    start = "a3";
                                    type = a3.Text;
                                    a3.Text = "";
                                }
                            }
                            break;
                        }
                    case "b3":
                        {
                            if (whiteMove == true)
                            {
                                if (b3.Text == "♔" || b3.Text == "♕" || b3.Text == "♖" || b3.Text == "♗" || b3.Text == "♘" || b3.Text == "♙")             //White
                                {
                                    start = "b3";
                                    type = b3.Text;
                                    b3.Text = "";
                                }
                            }
                            else
                            {
                                if (b3.Text == "♚" || b3.Text == "♛" || b3.Text == "♜" || b3.Text == "♝" || b3.Text == "♞" || b3.Text == "♟")             //Black
                                {
                                    start = "b3";
                                    type = b3.Text;
                                    b3.Text = "";
                                }
                            }
                            break;
                        }
                    case "c3":
                        {
                            if (whiteMove == true)
                            {
                                if (c3.Text == "♔" || c3.Text == "♕" || c3.Text == "♖" || c3.Text == "♗" || c3.Text == "♘" || c3.Text == "♙")             //White
                                {
                                    start = "c3";
                                    type = c3.Text;
                                    c3.Text = "";
                                }
                            }
                            else
                            {
                                if (c3.Text == "♚" || c3.Text == "♛" || c3.Text == "♜" || c3.Text == "♝" || c3.Text == "♞" || c3.Text == "♟")             //Black
                                {
                                    start = "c3";
                                    type = c3.Text;
                                    c3.Text = "";
                                }
                            }
                            break;
                        }
                    case "d3":
                        {
                            if (whiteMove == true)
                            {
                                if (d3.Text == "♔" || d3.Text == "♕" || d3.Text == "♖" || d3.Text == "♗" || d3.Text == "♘" || d3.Text == "♙")             //White
                                {
                                    start = "d3";
                                    type = d3.Text;
                                    d3.Text = "";
                                }
                            }
                            else
                            {
                                if (d3.Text == "♚" || d3.Text == "♛" || d3.Text == "♜" || d3.Text == "♝" || d3.Text == "♞" || d3.Text == "♟")             //Black
                                {
                                    start = "d3";
                                    type = d3.Text;
                                    d3.Text = "";
                                }
                            }
                            break;
                        }
                    case "e3":
                        {
                            if (whiteMove == true)
                            {
                                if (e3.Text == "♔" || e3.Text == "♕" || e3.Text == "♖" || e3.Text == "♗" || e3.Text == "♘" || e3.Text == "♙")             //White
                                {
                                    start = "e3";
                                    type = e3.Text;
                                    e3.Text = "";
                                }
                            }
                            else
                            {
                                if (e3.Text == "♚" || e3.Text == "♛" || e3.Text == "♜" || e3.Text == "♝" || e3.Text == "♞" || e3.Text == "♟")             //Black
                                {
                                    start = "e3";
                                    type = e3.Text;
                                    e3.Text = "";
                                }
                            }
                            break;
                        }
                    case "f3":
                        {
                            if (whiteMove == true)
                            {
                                if (f3.Text == "♔" || f3.Text == "♕" || f3.Text == "♖" || f3.Text == "♗" || f3.Text == "♘" || f3.Text == "♙")             //White
                                {
                                    start = "f3";
                                    type = f3.Text;
                                    f3.Text = "";
                                }
                            }
                            else
                            {
                                if (f3.Text == "♚" || f3.Text == "♛" || f3.Text == "♜" || f3.Text == "♝" || f3.Text == "♞" || f3.Text == "♟")             //Black
                                {
                                    start = "f3";
                                    type = f3.Text;
                                    f3.Text = "";
                                }
                            }
                            break;
                        }
                    case "g3":
                        {
                            if (whiteMove == true)
                            {
                                if (g3.Text == "♔" || g3.Text == "♕" || g3.Text == "♖" || g3.Text == "♗" || g3.Text == "♘" || g3.Text == "♙")             //White
                                {
                                    start = "g3";
                                    type = g3.Text;
                                    g3.Text = "";
                                }
                            }
                            else
                            {
                                if (g3.Text == "♚" || g3.Text == "♛" || g3.Text == "♜" || g3.Text == "♝" || g3.Text == "♞" || g3.Text == "♟")             //Black
                                {
                                    start = "g3";
                                    type = g3.Text;
                                    g3.Text = "";
                                }
                            }
                            break;
                        }
                    case "h3":
                        {
                            if (whiteMove == true)
                            {
                                if (h3.Text == "♔" || h3.Text == "♕" || h3.Text == "♖" || h3.Text == "♗" || h3.Text == "♘" || h3.Text == "♙")             //White
                                {
                                    start = "h3";
                                    type = h3.Text;
                                    h3.Text = "";
                                }
                            }
                            else
                            {
                                if (h3.Text == "♚" || h3.Text == "♛" || h3.Text == "♜" || h3.Text == "♝" || h3.Text == "♞" || h3.Text == "♟")             //Black
                                {
                                    start = "h3";
                                    type = h3.Text;
                                    h3.Text = "";
                                }
                            }
                            break;
                        }
                    case "a4":
                        {
                            if (whiteMove == true)
                            {
                                if (a4.Text == "♔" || a4.Text == "♕" || a4.Text == "♖" || a4.Text == "♗" || a4.Text == "♘" || a4.Text == "♙")             //White
                                {
                                    start = "a4";
                                    type = a4.Text;
                                    a4.Text = "";
                                }
                            }
                            else
                            {
                                if (a4.Text == "♚" || a4.Text == "♛" || a4.Text == "♜" || a4.Text == "♝" || a4.Text == "♞" || a4.Text == "♟")             //Black
                                {
                                    start = "a4";
                                    type = a4.Text;
                                    a4.Text = "";
                                }
                            }
                            break;
                        }
                    case "b4":
                        {
                            if (whiteMove == true)
                            {
                                if (b4.Text == "♔" || b4.Text == "♕" || b4.Text == "♖" || b4.Text == "♗" || b4.Text == "♘" || b4.Text == "♙")             //White
                                {
                                    start = "b4";
                                    type = b4.Text;
                                    b4.Text = "";
                                }
                            }
                            else
                            {
                                if (b4.Text == "♚" || b4.Text == "♛" || b4.Text == "♜" || b4.Text == "♝" || b4.Text == "♞" || b4.Text == "♟")             //Black
                                {
                                    start = "b4";
                                    type = b4.Text;
                                    b4.Text = "";
                                }
                            }
                            break;
                        }
                    case "c4":
                        {
                            if (whiteMove == true)
                            {
                                if (c4.Text == "♔" || c4.Text == "♕" || c4.Text == "♖" || c4.Text == "♗" || c4.Text == "♘" || c4.Text == "♙")             //White
                                {
                                    start = "c4";
                                    type = c4.Text;
                                    c4.Text = "";
                                }
                            }
                            else
                            {
                                if (c4.Text == "♚" || c4.Text == "♛" || c4.Text == "♜" || c4.Text == "♝" || c4.Text == "♞" || c4.Text == "♟")             //Black
                                {
                                    start = "c4";
                                    type = c4.Text;
                                    c4.Text = "";
                                }
                            }
                            break;
                        }
                    case "d4":
                        {
                            if (whiteMove == true)
                            {
                                if (d4.Text == "♔" || d4.Text == "♕" || d4.Text == "♖" || d4.Text == "♗" || d4.Text == "♘" || d4.Text == "♙")             //White
                                {
                                    start = "d4";
                                    type = d4.Text;
                                    d4.Text = "";
                                }
                            }
                            else
                            {
                                if (d4.Text == "♚" || d4.Text == "♛" || d4.Text == "♜" || d4.Text == "♝" || d4.Text == "♞" || d4.Text == "♟")             //Black
                                {
                                    start = "d4";
                                    type = d4.Text;
                                    d4.Text = "";
                                }
                            }
                            break;
                        }
                    case "e4":
                        {
                            if (whiteMove == true)
                            {
                                if (e4.Text == "♔" || e4.Text == "♕" || e4.Text == "♖" || e4.Text == "♗" || e4.Text == "♘" || e4.Text == "♙")             //White
                                {
                                    start = "e4";
                                    type = e4.Text;
                                    e4.Text = "";
                                }
                            }
                            else
                            {
                                if (e4.Text == "♚" || e4.Text == "♛" || e4.Text == "♜" || e4.Text == "♝" || e4.Text == "♞" || e4.Text == "♟")             //Black
                                {
                                    start = "e4";
                                    type = e4.Text;
                                    e4.Text = "";
                                }
                            }
                            break;
                        }
                    case "f4":
                        {
                            if (whiteMove == true)
                            {
                                if (f4.Text == "♔" || f4.Text == "♕" || f4.Text == "♖" || f4.Text == "♗" || f4.Text == "♘" || f4.Text == "♙")             //White
                                {
                                    start = "f4";
                                    type = f4.Text;
                                    f4.Text = "";
                                }
                            }
                            else
                            {
                                if (f4.Text == "♚" || f4.Text == "♛" || f4.Text == "♜" || f4.Text == "♝" || f4.Text == "♞" || f4.Text == "♟")             //Black
                                {
                                    start = "f4";
                                    type = f4.Text;
                                    f4.Text = "";
                                }
                            }
                            break;
                        }
                    case "g4":
                        {
                            if (whiteMove == true)
                            {
                                if (g4.Text == "♔" || g4.Text == "♕" || g4.Text == "♖" || g4.Text == "♗" || g4.Text == "♘" || g4.Text == "♙")             //White
                                {
                                    start = "g4";
                                    type = g4.Text;
                                    g4.Text = "";
                                }
                            }
                            else
                            {
                                if (g4.Text == "♚" || g4.Text == "♛" || g4.Text == "♜" || g4.Text == "♝" || g4.Text == "♞" || g4.Text == "♟")             //Black
                                {
                                    start = "g4";
                                    type = g4.Text;
                                    g4.Text = "";
                                }
                            }
                            break;
                        }
                    case "h4":
                        {
                            if (whiteMove == true)
                            {
                                if (h4.Text == "♔" || h4.Text == "♕" || h4.Text == "♖" || h4.Text == "♗" || h4.Text == "♘" || h4.Text == "♙")             //White
                                {
                                    start = "h4";
                                    type = h4.Text;
                                    h4.Text = "";
                                }
                            }
                            else
                            {
                                if (h4.Text == "♚" || h4.Text == "♛" || h4.Text == "♜" || h4.Text == "♝" || h4.Text == "♞" || h4.Text == "♟")             //Black
                                {
                                    start = "h4";
                                    type = h4.Text;
                                    h4.Text = "";
                                }
                            }
                            break;
                        }
                    case "a5":
                        {
                            if (whiteMove == true)
                            {
                                if (a5.Text == "♔" || a5.Text == "♕" || a5.Text == "♖" || a5.Text == "♗" || a5.Text == "♘" || a5.Text == "♙")             //White
                                {
                                    start = "a5";
                                    type = a5.Text;
                                    a5.Text = "";
                                }
                            }
                            else
                            {
                                if (a5.Text == "♚" || a5.Text == "♛" || a5.Text == "♜" || a5.Text == "♝" || a5.Text == "♞" || a5.Text == "♟")             //Black
                                {
                                    start = "a5";
                                    type = a5.Text;
                                    a5.Text = "";
                                }
                            }
                            break;
                        }
                    case "b5":
                        {
                            if (whiteMove == true)
                            {
                                if (b5.Text == "♔" || b5.Text == "♕" || b5.Text == "♖" || b5.Text == "♗" || b5.Text == "♘" || b5.Text == "♙")             //White
                                {
                                    start = "b5";
                                    type = b5.Text;
                                    b5.Text = "";
                                }
                            }
                            else
                            {
                                if (b5.Text == "♚" || b5.Text == "♛" || b5.Text == "♜" || b5.Text == "♝" || b5.Text == "♞" || b5.Text == "♟")             //Black
                                {
                                    start = "b5";
                                    type = b5.Text;
                                    b5.Text = "";
                                }
                            }
                            break;
                        }
                    case "c5":
                        {
                            if (whiteMove == true)
                            {
                                if (c5.Text == "♔" || c5.Text == "♕" || c5.Text == "♖" || c5.Text == "♗" || c5.Text == "♘" || c5.Text == "♙")             //White
                                {
                                    start = "c5";
                                    type = c5.Text;
                                    c5.Text = "";
                                }
                            }
                            else
                            {
                                if (c5.Text == "♚" || c5.Text == "♛" || c5.Text == "♜" || c5.Text == "♝" || c5.Text == "♞" || c5.Text == "♟")             //Black
                                {
                                    start = "c5";
                                    type = c5.Text;
                                    c5.Text = "";
                                }
                            }
                            break;
                        }
                    case "d5":
                        {
                            if (whiteMove == true)
                            {
                                if (d5.Text == "♔" || d5.Text == "♕" || d5.Text == "♖" || d5.Text == "♗" || d5.Text == "♘" || d5.Text == "♙")             //White
                                {
                                    start = "d5";
                                    type = d5.Text;
                                    d5.Text = "";
                                }
                            }
                            else
                            {
                                if (d5.Text == "♚" || d5.Text == "♛" || d5.Text == "♜" || d5.Text == "♝" || d5.Text == "♞" || d5.Text == "♟")             //Black
                                {
                                    start = "d5";
                                    type = d5.Text;
                                    d5.Text = "";
                                }
                            }
                            break;
                        }
                    case "e5":
                        {
                            if (whiteMove == true)
                            {
                                if (e5.Text == "♔" || e5.Text == "♕" || e5.Text == "♖" || e5.Text == "♗" || e5.Text == "♘" || e5.Text == "♙")             //White
                                {
                                    start = "e5";
                                    type = e5.Text;
                                    e5.Text = "";
                                }
                            }
                            else
                            {
                                if (e5.Text == "♚" || e5.Text == "♛" || e5.Text == "♜" || e5.Text == "♝" || e5.Text == "♞" || e5.Text == "♟")             //Black
                                {
                                    start = "e5";
                                    type = e5.Text;
                                    e5.Text = "";
                                }
                            }
                            break;
                        }
                    case "f5":
                        {
                            if (whiteMove == true)
                            {
                                if (f5.Text == "♔" || f5.Text == "♕" || f5.Text == "♖" || f5.Text == "♗" || f5.Text == "♘" || f5.Text == "♙")             //White
                                {
                                    start = "f5";
                                    type = f5.Text;
                                    f5.Text = "";
                                }
                            }
                            else
                            {
                                if (f5.Text == "♚" || f5.Text == "♛" || f5.Text == "♜" || f5.Text == "♝" || f5.Text == "♞" || f5.Text == "♟")             //Black
                                {
                                    start = "f5";
                                    type = f5.Text;
                                    f5.Text = "";
                                }
                            }
                            break;
                        }
                    case "g5":
                        {
                            if (whiteMove == true)
                            {
                                if (g5.Text == "♔" || g5.Text == "♕" || g5.Text == "♖" || g5.Text == "♗" || g5.Text == "♘" || g5.Text == "♙")             //White
                                {
                                    start = "g5";
                                    type = g5.Text;
                                    g5.Text = "";
                                }
                            }
                            else
                            {
                                if (g5.Text == "♚" || g5.Text == "♛" || g5.Text == "♜" || g5.Text == "♝" || g5.Text == "♞" || g5.Text == "♟")             //Black
                                {
                                    start = "g5";
                                    type = g5.Text;
                                    g5.Text = "";
                                }
                            }
                            break;
                        }
                    case "h5":
                        {
                            if (whiteMove == true)
                            {
                                if (h5.Text == "♔" || h5.Text == "♕" || h5.Text == "♖" || h5.Text == "♗" || h5.Text == "♘" || h5.Text == "♙")             //White
                                {
                                    start = "h5";
                                    type = h5.Text;
                                    h5.Text = "";
                                }
                            }
                            else
                            {
                                if (h5.Text == "♚" || h5.Text == "♛" || h5.Text == "♜" || h5.Text == "♝" || h5.Text == "♞" || h5.Text == "♟")             //Black
                                {
                                    start = "h5";
                                    type = h5.Text;
                                    h5.Text = "";
                                }
                            }
                            break;
                        }
                    case "a6":
                        {
                            if (whiteMove == true)
                            {
                                if (a6.Text == "♔" || a6.Text == "♕" || a6.Text == "♖" || a6.Text == "♗" || a6.Text == "♘" || a6.Text == "♙")             //White
                                {
                                    start = "a6";
                                    type = a6.Text;
                                    a6.Text = "";
                                }
                            }
                            else
                            {
                                if (a6.Text == "♚" || a6.Text == "♛" || a6.Text == "♜" || a6.Text == "♝" || a6.Text == "♞" || a6.Text == "♟")             //Black
                                {
                                    start = "a6";
                                    type = a6.Text;
                                    a6.Text = "";
                                }
                            }
                            break;
                        }
                    case "b6":
                        {
                            if (whiteMove == true)
                            {
                                if (b6.Text == "♔" || b6.Text == "♕" || b6.Text == "♖" || b6.Text == "♗" || b6.Text == "♘" || b6.Text == "♙")             //White
                                {
                                    start = "b6";
                                    type = b6.Text;
                                    b6.Text = "";
                                }
                            }
                            else
                            {
                                if (b6.Text == "♚" || b6.Text == "♛" || b6.Text == "♜" || b6.Text == "♝" || b6.Text == "♞" || b6.Text == "♟")             //Black
                                {
                                    start = "b6";
                                    type = b6.Text;
                                    b6.Text = "";
                                }
                            }
                            break;
                        }
                    case "c6":
                        {
                            if (whiteMove == true)
                            {
                                if (c6.Text == "♔" || c6.Text == "♕" || c6.Text == "♖" || c6.Text == "♗" || c6.Text == "♘" || c6.Text == "♙")             //White
                                {
                                    start = "c6";
                                    type = c6.Text;
                                    c6.Text = "";
                                }
                            }
                            else
                            {
                                if (c6.Text == "♚" || c6.Text == "♛" || c6.Text == "♜" || c6.Text == "♝" || c6.Text == "♞" || c6.Text == "♟")             //Black
                                {
                                    start = "c6";
                                    type = c6.Text;
                                    c6.Text = "";
                                }
                            }
                            break;
                        }
                    case "d6":
                        {
                            if (whiteMove == true)
                            {
                                if (d6.Text == "♔" || d6.Text == "♕" || d6.Text == "♖" || d6.Text == "♗" || d6.Text == "♘" || d6.Text == "♙")             //White
                                {
                                    start = "d6";
                                    type = d6.Text;
                                    d6.Text = "";
                                }
                            }
                            else
                            {
                                if (d6.Text == "♚" || d6.Text == "♛" || d6.Text == "♜" || d6.Text == "♝" || d6.Text == "♞" || d6.Text == "♟")             //Black
                                {
                                    start = "d6";
                                    type = d6.Text;
                                    d6.Text = "";
                                }
                            }
                            break;
                        }
                    case "e6":
                        {
                            if (whiteMove == true)
                            {
                                if (e6.Text == "♔" || e6.Text == "♕" || e6.Text == "♖" || e6.Text == "♗" || e6.Text == "♘" || e6.Text == "♙")             //White
                                {
                                    start = "e6";
                                    type = e6.Text;
                                    e6.Text = "";
                                }
                            }
                            else
                            {
                                if (e6.Text == "♚" || e6.Text == "♛" || e6.Text == "♜" || e6.Text == "♝" || e6.Text == "♞" || e6.Text == "♟")             //Black
                                {
                                    start = "e6";
                                    type = e6.Text;
                                    e6.Text = "";
                                }
                            }
                            break;
                        }
                    case "f6":
                        {
                            if (whiteMove == true)
                            {
                                if (f6.Text == "♔" || f6.Text == "♕" || f6.Text == "♖" || f6.Text == "♗" || f6.Text == "♘" || f6.Text == "♙")             //White
                                {
                                    start = "f6";
                                    type = f6.Text;
                                    f6.Text = "";
                                }
                            }
                            else
                            {
                                if (f6.Text == "♚" || f6.Text == "♛" || f6.Text == "♜" || f6.Text == "♝" || f6.Text == "♞" || f6.Text == "♟")             //Black
                                {
                                    start = "f6";
                                    type = f6.Text;
                                    f6.Text = "";
                                }
                            }
                            break;
                        }
                    case "g6":
                        {
                            if (whiteMove == true)
                            {
                                if (g6.Text == "♔" || g6.Text == "♕" || g6.Text == "♖" || g6.Text == "♗" || g6.Text == "♘" || g6.Text == "♙")             //White
                                {
                                    start = "g6";
                                    type = g6.Text;
                                    g6.Text = "";
                                }
                            }
                            else
                            {
                                if (g6.Text == "♚" || g6.Text == "♛" || g6.Text == "♜" || g6.Text == "♝" || g6.Text == "♞" || g6.Text == "♟")             //Black
                                {
                                    start = "g6";
                                    type = g6.Text;
                                    g6.Text = "";
                                }
                            }
                            break;
                        }
                    case "h6":
                        {
                            if (whiteMove == true)
                            {
                                if (h6.Text == "♔" || h6.Text == "♕" || h6.Text == "♖" || h6.Text == "♗" || h6.Text == "♘" || h6.Text == "♙")             //White
                                {
                                    start = "h6";
                                    type = h6.Text;
                                    h6.Text = "";
                                }
                            }
                            else
                            {
                                if (h6.Text == "♚" || h6.Text == "♛" || h6.Text == "♜" || h6.Text == "♝" || h6.Text == "♞" || h6.Text == "♟")             //Black
                                {
                                    start = "h6";
                                    type = h6.Text;
                                    h6.Text = "";
                                }
                            }
                            break;
                        }
                    case "a7":
                        {
                            if (whiteMove == true)
                            {
                                if (a7.Text == "♔" || a7.Text == "♕" || a7.Text == "♖" || a7.Text == "♗" || a7.Text == "♘" || a7.Text == "♙")             //White
                                {
                                    start = "a7";
                                    type = a7.Text;
                                    a7.Text = "";
                                }
                            }
                            else
                            {
                                if (a7.Text == "♚" || a7.Text == "♛" || a7.Text == "♜" || a7.Text == "♝" || a7.Text == "♞" || a7.Text == "♟")             //Black
                                {
                                    start = "a7";
                                    type = a7.Text;
                                    a7.Text = "";
                                }
                            }
                            break;
                        }
                    case "b7":
                        {
                            if (whiteMove == true)
                            {
                                if (b7.Text == "♔" || b7.Text == "♕" || b7.Text == "♖" || b7.Text == "♗" || b7.Text == "♘" || b7.Text == "♙")             //White
                                {
                                    start = "b7";
                                    type = b7.Text;
                                    b7.Text = "";
                                }
                            }
                            else
                            {
                                if (b7.Text == "♚" || b7.Text == "♛" || b7.Text == "♜" || b7.Text == "♝" || b7.Text == "♞" || b7.Text == "♟")             //Black
                                {
                                    start = "b7";
                                    type = b7.Text;
                                    b7.Text = "";
                                }
                            }
                            break;
                        }
                    case "c7":
                        {
                            if (whiteMove == true)
                            {
                                if (c7.Text == "♔" || c7.Text == "♕" || c7.Text == "♖" || c7.Text == "♗" || c7.Text == "♘" || c7.Text == "♙")             //White
                                {
                                    start = "c7";
                                    type = c7.Text;
                                    c7.Text = "";
                                }
                            }
                            else
                            {
                                if (c7.Text == "♚" || c7.Text == "♛" || c7.Text == "♜" || c7.Text == "♝" || c7.Text == "♞" || c7.Text == "♟")             //Black
                                {
                                    start = "c7";
                                    type = c7.Text;
                                    c7.Text = "";
                                }
                            }
                            break;
                        }
                    case "d7":
                        {
                            if (whiteMove == true)
                            {
                                if (d7.Text == "♔" || d7.Text == "♕" || d7.Text == "♖" || d7.Text == "♗" || d7.Text == "♘" || d7.Text == "♙")             //White
                                {
                                    start = "d7";
                                    type = d7.Text;
                                    d7.Text = "";
                                }
                            }
                            else
                            {
                                if (d7.Text == "♚" || d7.Text == "♛" || d7.Text == "♜" || d7.Text == "♝" || d7.Text == "♞" || d7.Text == "♟")             //Black
                                {
                                    start = "d7";
                                    type = d7.Text;
                                    d7.Text = "";
                                }
                            }
                            break;
                        }
                    case "e7":
                        {
                            if (whiteMove == true)
                            {
                                if (e7.Text == "♔" || e7.Text == "♕" || e7.Text == "♖" || e7.Text == "♗" || e7.Text == "♘" || e7.Text == "♙")             //White
                                {
                                    start = "e7";
                                    type = e7.Text;
                                    e7.Text = "";
                                }
                            }
                            else
                            {
                                if (e7.Text == "♚" || e7.Text == "♛" || e7.Text == "♜" || e7.Text == "♝" || e7.Text == "♞" || e7.Text == "♟")             //Black
                                {
                                    start = "e7";
                                    type = e7.Text;
                                    e7.Text = "";
                                }
                            }
                            break;
                        }
                    case "f7":
                        {
                            if (whiteMove == true)
                            {
                                if (f7.Text == "♔" || f7.Text == "♕" || f7.Text == "♖" || f7.Text == "♗" || f7.Text == "♘" || f7.Text == "♙")             //White
                                {
                                    start = "f7";
                                    type = f7.Text;
                                    f7.Text = "";
                                }
                            }
                            else
                            {
                                if (f7.Text == "♚" || f7.Text == "♛" || f7.Text == "♜" || f7.Text == "♝" || f7.Text == "♞" || f7.Text == "♟")             //Black
                                {
                                    start = "f7";
                                    type = f7.Text;
                                    f7.Text = "";
                                }
                            }
                            break;
                        }
                    case "g7":
                        {
                            if (whiteMove == true)
                            {
                                if (g7.Text == "♔" || g7.Text == "♕" || g7.Text == "♖" || g7.Text == "♗" || g7.Text == "♘" || g7.Text == "♙")             //White
                                {
                                    start = "g7";
                                    type = g7.Text;
                                    g7.Text = "";
                                }
                            }
                            else
                            {
                                if (g7.Text == "♚" || g7.Text == "♛" || g7.Text == "♜" || g7.Text == "♝" || g7.Text == "♞" || g7.Text == "♟")             //Black
                                {
                                    start = "g7";
                                    type = g7.Text;
                                    g7.Text = "";
                                }
                            }
                            break;
                        }
                    case "h7":
                        {
                            if (whiteMove == true)
                            {
                                if (h7.Text == "♔" || h7.Text == "♕" || h7.Text == "♖" || h7.Text == "♗" || h7.Text == "♘" || h7.Text == "♙")             //White
                                {
                                    start = "h7";
                                    type = h7.Text;
                                    h7.Text = "";
                                }
                            }
                            else
                            {
                                if (h7.Text == "♚" || h7.Text == "♛" || h7.Text == "♜" || h7.Text == "♝" || h7.Text == "♞" || h7.Text == "♟")             //Black
                                {
                                    start = "h7";
                                    type = h7.Text;
                                    h7.Text = "";
                                }
                            }
                            break;
                        }
                    case "a8":
                        {
                            if (whiteMove == true)
                            {
                                if (a8.Text == "♔" || a8.Text == "♕" || a8.Text == "♖" || a8.Text == "♗" || a8.Text == "♘" || a8.Text == "♙")             //White
                                {
                                    start = "a8";
                                    type = a8.Text;
                                    a8.Text = "";
                                }
                            }
                            else
                            {
                                if (a8.Text == "♚" || a8.Text == "♛" || a8.Text == "♜" || a8.Text == "♝" || a8.Text == "♞" || a8.Text == "♟")             //Black
                                {
                                    start = "a8";
                                    type = a8.Text;
                                    a8.Text = "";
                                }
                            }
                            break;
                        }
                    case "b8":
                        {
                            if (whiteMove == true)
                            {
                                if (b8.Text == "♔" || b8.Text == "♕" || b8.Text == "♖" || b8.Text == "♗" || b8.Text == "♘" || b8.Text == "♙")             //White
                                {
                                    start = "b8";
                                    type = b8.Text;
                                    b8.Text = "";
                                }
                            }
                            else
                            {
                                if (b8.Text == "♚" || b8.Text == "♛" || b8.Text == "♜" || b8.Text == "♝" || b8.Text == "♞" || b8.Text == "♟")             //Black
                                {
                                    start = "b8";
                                    type = b8.Text;
                                    b8.Text = "";
                                }
                            }
                            break;
                        }
                    case "c8":
                        {
                            if (whiteMove == true)
                            {
                                if (c8.Text == "♔" || c8.Text == "♕" || c8.Text == "♖" || c8.Text == "♗" || c8.Text == "♘" || c8.Text == "♙")             //White
                                {
                                    start = "c8";
                                    type = c8.Text;
                                    c8.Text = "";
                                }
                            }
                            else
                            {
                                if (c8.Text == "♚" || c8.Text == "♛" || c8.Text == "♜" || c8.Text == "♝" || c8.Text == "♞" || c8.Text == "♟")             //Black
                                {
                                    start = "c8";
                                    type = c8.Text;
                                    c8.Text = "";
                                }
                            }
                            break;
                        }
                    case "d8":
                        {
                            if (whiteMove == true)
                            {
                                if (d8.Text == "♔" || d8.Text == "♕" || d8.Text == "♖" || d8.Text == "♗" || d8.Text == "♘" || d8.Text == "♙")             //White
                                {
                                    start = "d8";
                                    type = d8.Text;
                                    d8.Text = "";
                                }
                            }
                            else
                            {
                                if (d8.Text == "♚" || d8.Text == "♛" || d8.Text == "♜" || d8.Text == "♝" || d8.Text == "♞" || d8.Text == "♟")             //Black
                                {
                                    start = "d8";
                                    type = d8.Text;
                                    d8.Text = "";
                                }
                            }
                            break;
                        }
                    case "e8":
                        {
                            if (whiteMove == true)
                            {
                                if (e8.Text == "♔" || e8.Text == "♕" || e8.Text == "♖" || e8.Text == "♗" || e8.Text == "♘" || e8.Text == "♙")             //White
                                {
                                    start = "e8";
                                    type = e8.Text;
                                    e8.Text = "";
                                }
                            }
                            else
                            {
                                if (e8.Text == "♚" || e8.Text == "♛" || e8.Text == "♜" || e8.Text == "♝" || e8.Text == "♞" || e8.Text == "♟")             //Black
                                {
                                    start = "e8";
                                    type = e8.Text;
                                    e8.Text = "";
                                }
                            }
                            break;
                        }
                    case "f8":
                        {
                            if (whiteMove == true)
                            {
                                if (f8.Text == "♔" || f8.Text == "♕" || f8.Text == "♖" || f8.Text == "♗" || f8.Text == "♘" || f8.Text == "♙")             //White
                                {
                                    start = "f8";
                                    type = f8.Text;
                                    f8.Text = "";
                                }
                            }
                            else
                            {
                                if (f8.Text == "♚" || f8.Text == "♛" || f8.Text == "♜" || f8.Text == "♝" || f8.Text == "♞" || f8.Text == "♟")             //Black
                                {
                                    start = "f8";
                                    type = f8.Text;
                                    f8.Text = "";
                                }
                            }
                            break;
                        }
                    case "g8":
                        {
                            if (whiteMove == true)
                            {
                                if (g8.Text == "♔" || g8.Text == "♕" || g8.Text == "♖" || g8.Text == "♗" || g8.Text == "♘" || g8.Text == "♙")             //White
                                {
                                    start = "g8";
                                    type = g8.Text;
                                    g8.Text = "";
                                }
                            }
                            else
                            {
                                if (g8.Text == "♚" || g8.Text == "♛" || g8.Text == "♜" || g8.Text == "♝" || g8.Text == "♞" || g8.Text == "♟")             //Black
                                {
                                    start = "g8";
                                    type = g8.Text;
                                    g8.Text = "";
                                }
                            }
                            break;
                        }
                    case "h8":
                        {
                            if (whiteMove == true)
                            {
                                if (h8.Text == "♔" || h8.Text == "♕" || h8.Text == "♖" || h8.Text == "♗" || h8.Text == "♘" || h8.Text == "♙")             //White
                                {
                                    start = "h8";
                                    type = h8.Text;
                                    h8.Text = "";
                                }
                            }
                            else
                            {
                                if (h8.Text == "♚" || h8.Text == "♛" || h8.Text == "♜" || h8.Text == "♝" || h8.Text == "♞" || h8.Text == "♟")             //Black
                                {
                                    start = "h8";
                                    type = h8.Text;
                                    h8.Text = "";
                                }
                            }
                            break;
                        }


                }
            }
            else
            {
                switch (position)
                {
                    case "a1":
                        {
                            a1.Text = type;
                            break;
                        }
                    case "b1":
                        {
                            b1.Text = type;
                            break;
                        }
                    case "c1":
                        {
                            c1.Text = type;
                            break;
                        }
                    case "d1":
                        {
                            d1.Text = type;
                            break;
                        }
                    case "e1":
                        {
                            e1.Text = type;
                            break;
                        }
                    case "f1":
                        {
                            f1.Text = type;
                            break;
                        }
                    case "g1":
                        {
                            g1.Text = type;
                            break;
                        }
                    case "h1":
                        {
                            h1.Text = type;
                            break;
                        }
                    case "a2":
                        {
                            a2.Text = type;
                            break;
                        }
                    case "b2":
                        {
                            b2.Text = type;
                            break;
                        }
                    case "c2":
                        {
                            c2.Text = type;
                            break;
                        }
                    case "d2":
                        {
                            d2.Text = type;
                            break;
                        }
                    case "e2":
                        {
                            e2.Text = type;
                            break;
                        }
                    case "f2":
                        {
                            f2.Text = type;
                            break;
                        }
                    case "g2":
                        {
                            g2.Text = type;
                            break;
                        }
                    case "h2":
                        {
                            h2.Text = type;
                            break;
                        }
                    case "a3":
                        {
                            a3.Text = type;
                            break;
                        }
                    case "b3":
                        {
                            b3.Text = type;
                            break;
                        }
                    case "c3":
                        {
                            c3.Text = type;
                            break;
                        }
                    case "d3":
                        {
                            d3.Text = type;
                            break;
                        }
                    case "e3":
                        {
                            e3.Text = type;
                            break;
                        }
                    case "f3":
                        {
                            f3.Text = type;
                            break;
                        }
                    case "g3":
                        {
                            g3.Text = type;
                            break;
                        }
                    case "h3":
                        {
                            h3.Text = type;
                            break;
                        }
                    case "a4":
                        {
                            a4.Text = type;
                            break;
                        }
                    case "b4":
                        {
                            b4.Text = type;
                            break;
                        }
                    case "c4":
                        {
                            c4.Text = type;
                            break;
                        }
                    case "d4":
                        {
                            d4.Text = type;
                            break;
                        }
                    case "e4":
                        {
                            e4.Text = type;
                            break;
                        }
                    case "f4":
                        {
                            f4.Text = type;
                            break;
                        }
                    case "g4":
                        {
                            g4.Text = type;
                            break;
                        }
                    case "h4":
                        {
                            h4.Text = type;
                            break;
                        }
                    case "a5":
                        {
                            a5.Text = type;
                            break;
                        }
                    case "b5":
                        {
                            b5.Text = type;
                            break;
                        }
                    case "c5":
                        {
                            c5.Text = type;
                            break;
                        }
                    case "d5":
                        {
                            d5.Text = type;
                            break;
                        }
                    case "e5":
                        {
                            e5.Text = type;
                            break;
                        }
                    case "f5":
                        {
                            f5.Text = type;
                            break;
                        }
                    case "g5":
                        {
                            g5.Text = type;
                            break;
                        }
                    case "h5":
                        {
                            h5.Text = type;
                            break;
                        }
                    case "a6":
                        {
                            a6.Text = type;
                            break;
                        }
                    case "b6":
                        {
                            b6.Text = type;
                            break;
                        }
                    case "c6":
                        {
                            c6.Text = type;
                            break;
                        }
                    case "d6":
                        {
                            d6.Text = type;
                            break;
                        }
                    case "e6":
                        {
                            e6.Text = type;
                            break;
                        }
                    case "f6":
                        {
                            f6.Text = type;
                            break;
                        }
                    case "g6":
                        {
                            g6.Text = type;
                            break;
                        }
                    case "h6":
                        {
                            h6.Text = type;
                            break;
                        }
                    case "a7":
                        {
                            a7.Text = type;
                            break;
                        }
                    case "b7":
                        {
                            b7.Text = type;
                            break;
                        }
                    case "c7":
                        {
                            c7.Text = type;
                            break;
                        }
                    case "d7":
                        {
                            d7.Text = type;
                            break;
                        }
                    case "e7":
                        {
                            e7.Text = type;
                            break;
                        }
                    case "f7":
                        {
                            f7.Text = type;
                            break;
                        }
                    case "g7":
                        {
                            g7.Text = type;
                            break;
                        }
                    case "h7":
                        {
                            h7.Text = type;
                            break;
                        }
                    case "a8":
                        {
                            a8.Text = type;
                            break;
                        }
                    case "b8":
                        {
                            b8.Text = type;
                            break;
                        }
                    case "c8":
                        {
                            c8.Text = type;
                            break;
                        }
                    case "d8":
                        {
                            d8.Text = type;
                            break;
                        }
                    case "e8":
                        {
                            e8.Text = type;
                            break;
                        }
                    case "f8":
                        {
                            f8.Text = type;
                            break;
                        }
                    case "g8":
                        {
                            g8.Text = type;
                            break;
                        }
                    case "h8":
                        {
                            h8.Text = type;
                            break;
                        }

                }
                whiteMove = !whiteMove;
                start = "";
            }
        }
    }
}
