using System;                                //      ░██████╗░░█████╗░███╗░░░███╗███████╗  
using System.Collections.Generic;            //      ██╔════╝░██╔══██╗████╗░████║██╔════╝  
using System.ComponentModel;                 //      ██║░░██╗░███████║██╔████╔██║█████╗░░  
using System.Data;                           //      ██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  
using System.Drawing;                        //      ╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  
using System.Linq;                           //      ░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  
using System.Text.Json;                      //                    ██████╗░░█████╗░░░██╗██╗░█████╗░
using System.Threading.Tasks;                //                    ╚════██╗██╔══██╗░██╔╝██║██╔══██╗
using System.Windows.Forms;                  //                    ░░███╔═╝██║░░██║██╔╝░██║╚█████╔╝
using System.Media;                          //                    ██╔══╝░░██║░░██║███████║██╔══██╗
                                             //                    ███████╗╚█████╔╝╚════██║╚█████╔╝
                                             //                    ╚══════╝░╚════╝░░░░░░╚═╝░╚════╝░

namespace TwoThousandFortyEight
{
    public partial class Map : Form
    {
        private readonly Random _random;   // Variable for random spam block detection.
        private Label _appear_label; 
        private Point _down_point;       // Variable for detecting mouse movement (Down).
        private Point _up_point;        // Variable for detecting mouse movement (Up).
        private int _time_ms;
        private int _animation_tick;
        private GameState _state = new GameState();

        enum MoveDirection  // List of enumerations of possible 
        {                     // movements for the mouse only.
            Left,
            Right,
            Up,
            Down
        }

        public Map()   // Our form constructor Map.
        {
            _random = new Random();
            _appear_label = null!;
           
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)   // When our form loads, we change the colors of our... 
        {                                                       // panels and trigger the gameplay logic.
            panel_game_field.BackColor = Color.FromArgb(0xBB, 0xAD, 0xA0);
            panel_statistics.BackColor = Color.FromArgb(0xBB, 0xAD, 0xA0);
            panel_sensor.BackColor = Color.FromArgb(0xBB, 0xAD, 0xA0);
            this.ActiveControl = null;
            timer_clock.Interval = 1000;
            _time_ms = 0;
            
            timer_clock.Start();
            ClearGameField();
            AddCell();
            ColorCells();
        }

        #region Game backstage.
        private void ClearGameField()  // Initial Shape Cleanup.
        {
            foreach (var panel_item in panel_game_field.Controls)
            {
                if (panel_item is Label lbl)
                    lbl.Text = "0";
            }
        }

        private void AddCell()      // Basically, this is the main gameplay that adds an element...
        {                              //  to the list of labels and then randomly puts a new block on the panel.
            List<Label> empty_cell = new List<Label>();
            Label? lbl;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    String index_name = "cell" + i.ToString() + j.ToString();            
                    lbl = panel_game_field.Controls.Find(index_name, false)[0] as Label; 
                                                                                         
                    if (lbl?.Text == "0")                                                
                        empty_cell.Add(lbl);                                             
                }
            }
        
            if (empty_cell.Count == 0)
            {
                // Game over.
                return;
            }
        
            lbl = empty_cell[_random.Next(empty_cell.Count)];
            lbl.Text = "2";
            _appear_label = lbl;
        }

        private void ColorCells()   // The method colors our blocksю.
        {
            foreach (var panel_item in panel_game_field.Controls)
            {
                Label? lbl = panel_item as Label;

                if (lbl != null)
                {
                    switch (lbl.Text)
                    {
                        case "0":
                            lbl.BackColor = Color.FromArgb(0xBB, 0xAD, 0xA0);
                            lbl.ForeColor = Color.FromArgb(0xBB, 0xAD, 0xA0);
                            break;
                        case "2":
                            lbl.BackColor = Color.FromArgb(0xEE, 0xE4, 0xDA);
                            lbl.ForeColor = Color.FromArgb(0x77, 0x6E, 0x65);
                            break; 
                        case "4":
                            lbl.BackColor = Color.FromArgb(0xED, 0xE0, 0xC8);
                            lbl.ForeColor = Color.FromArgb(0x77, 0x6E, 0x65);
                            break;
                        case "8":
                            lbl.BackColor = Color.FromArgb(0xF2, 0xB1, 0x79);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "16":
                            lbl.BackColor = Color.FromArgb(0xF5, 0x95, 0x63);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "32":
                            lbl.BackColor = Color.FromArgb(0xF6, 0x7C, 0x5F);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "64":
                            lbl.BackColor = Color.FromArgb(0xF6, 0x5E, 0x3B);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "128":
                            lbl.BackColor = Color.FromArgb(0xED, 0xCF, 0x72);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "256":
                            lbl.BackColor = Color.FromArgb(0xED, 0xCC, 0x61);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "512":
                            lbl.BackColor = Color.FromArgb(0xED, 0xC8, 0x50);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "1024":
                            lbl.BackColor = Color.FromArgb(0xED, 0xC5, 0x3F);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "2048":
                            lbl.BackColor = Color.FromArgb(0xED, 0xC2, 0x2E);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        default:
                            lbl.BackColor = Color.FromArgb(0x3C, 0x3A, 0x32);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                    }
                    lbl.Tag = new AnimData { BackColor = lbl.BackColor };
                }
            }
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            _time_ms += timer_clock.Interval;

            int time_s = _time_ms / 1000;
            int h = time_s / 3600;
            int m = (time_s % 3600) / 60;
            int s = time_s % 60;

            label_time.Text = $"{h.ToString("00")}:{m.ToString($"00:{s.ToString("00")}")}";
        }

        class AnimData
        {
            public Color BackColor { get; set; }
        }

        private void timer_anim_Tick(object sender, EventArgs e)
        {
            var anim_data = _appear_label?.Tag as AnimData;

            if (_appear_label == null || anim_data == null)
            {
                timer_anim.Stop();
                return;
            }

            _appear_label.BackColor = Color.FromArgb(_animation_tick * 10, anim_data.BackColor);
            _appear_label.Font = new Font(_appear_label.Font.FontFamily, 18);
            _appear_label.Font = new Font(_appear_label.Font.FontFamily, 18 - _animation_tick / 4, FontStyle.Bold);
            _appear_label.Font = new Font(_appear_label.Font.FontFamily, _animation_tick / 2 + 10, FontStyle.Bold);
            _animation_tick++;

            if (_animation_tick >= 25)
            {
                _appear_label.BackColor = anim_data.BackColor;

                timer_anim.Stop();

                _appear_label = null!;
            }
        }
        #endregion

        #region Keyboard mechanics.
        private void Map_KeyDown(object sender, KeyEventArgs e)  // When a key is pressed, the method allows the pressed button and...
        {                                                           // passes it through the enumeration type *MoveDirection*.
            switch (e.KeyCode)
            {
                case Keys.Left:
                    MakeMove(MoveDirection.Left);
                    break;
                case Keys.Right:
                    MakeMove(MoveDirection.Right);
                    break;
                case Keys.Up:
                    MakeMove(MoveDirection.Up);
                    break;
                case Keys.Down:
                    MakeMove(MoveDirection.Down);
                    break;
                case Keys.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }
        
        private bool MoveLeft()   // Left movement method.
        {
            bool wasMove = false;

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 3; k++)                           
                {                                                    //
                    for (int j = 0; j < 3; j++)                     //
                    {                                               //  Determine where the blocks are.
                        Label lbl1 = LabelAt(i, j);                 //
                        Label lbl2 = LabelAt(i, j + 1);             //    - - - - -               - - - - - 
                                                                    //   |         |             |         |
                        if (lbl1.Text == "0" && lbl2.Text != "0")   //   |    i    |  < - - - -  |   j+1   | 
                        {                                           //   |         |             |         |
                            lbl1.Text = lbl2.Text;                  //    - - - - -               - - - - - 
                            lbl2.Text = "0";                        //
                            wasMove = true;                         //
                        }                                           //
                    }                                                //
                }

                for (int j = 0; j < 3; j++)                                 
                {                                                            //
                    Label lbl1 = LabelAt(i, j);                             //   
                    Label lbl2 = LabelAt(i, j + 1);                         //  
                                                                            //   
                    if (lbl1.Text == lbl2.Text)                             //  If the text of the elements is the same, then we absorb it.
                    {                                                       // 
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();    // 
                        lbl2.Text = "0";                                    // 
                        j++;                                                // 
                        wasMove = true;                                      // 
                    }                                                        
                }                                                            
                                                                             
                for (int j = 1; j < 3; j++)                                  
                {                                                            
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i, j + 1);

                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();
                        lbl2.Text = "0";
                        wasMove = true;
                    }
                }
            }

            return wasMove;
        }

        private bool MoveRight()  // Right movement method.
        {
            bool wasMove = false;

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 3; k++)
                {                                                 
                    for (int j = 3; j > 0; j--)                   
                    {                                             
                        Label lbl1 = LabelAt(i, j);               
                        Label lbl2 = LabelAt(i, j - 1);           
                                                                  
                        if (lbl1.Text == "0" && lbl2.Text != "0") 
                        {                                         
                            lbl1.Text = lbl2.Text;                
                            lbl2.Text = "0";                      
                            wasMove = true;                       
                        }                                         
                    }
                }

                for (int j = 3; j > 0; j--)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i, j - 1);

                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();
                        lbl2.Text = "0";
                        j--;
                        wasMove = true;
                    }
                }
                
                for (int j = 3; j > 0; j--)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i, j - 1);

                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();
                        lbl2.Text = "0";
                        wasMove = true;
                    }
                }
            }

            return wasMove;
        }

        private bool MoveUp()
        {
            bool wasMove = false;

            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int i = 0; i < 3; ++i)
                    {
                        Label lbl1 = LabelAt(i, j);
                        Label lbl2 = LabelAt(i + 1, j);

                        if (lbl1.Text == "0" && lbl2.Text != "0")
                        {
                            lbl1.Text = lbl2.Text;
                            lbl2.Text = "0";
                            wasMove = true;
                        }
                    }
                }

                for (int i = 0; i < 3; ++i)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i + 1, j);
                
                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();
                        lbl2.Text = "0";
                        i++;
                        wasMove = true;
                    }
                }
                
                for (int i = 1; i < 3; ++i)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i + 1, j);
                
                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();
                        lbl2.Text = "0";
                        wasMove = true;
                    }
                }
            }

            return wasMove;
        }

        private bool MoveDown()
        {
            bool wasMove = false;

            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int i = 3; i > 0; --i)
                    {
                        Label lbl1 = LabelAt(i, j);
                        Label lbl2 = LabelAt(i - 1, j);

                        if (lbl1.Text == "0" && lbl2.Text != "0")
                        {
                            lbl1.Text = lbl2.Text;
                            lbl2.Text = "0";
                            wasMove = true;
                        }
                    }
                }

                for (int i = 3; i > 0; --i)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i - 1, j);
                
                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();
                        lbl2.Text = "0";
                        i--;
                        wasMove = true;
                    }
                }
                
                for (int i = 3; i > 0; --i)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i - 1, j);
                
                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl2.Text)*2).ToString();
                        lbl2.Text = "0";
                        wasMove = true;
                    }
                }
            }

            return wasMove;
        }

        private Label LabelAt(int i, int j)  // The method determines adjacent elements.
        {
            return (Label)panel_game_field.Controls.Find("cell" + i + j, false)[0];
        }
        #endregion

        #region Mouse mechanics.
        private void panel_sensor_MouseDown(object sender, MouseEventArgs e)  // Passing _down_point coordinates.
        {
            _down_point.X = e.X;
            _down_point.Y = e.Y;
        }

        private void panel_sensor_MouseUp(object sender, MouseEventArgs e)  // Passing _up_point coordinates.
        {
            _up_point.X = e.X;
            _up_point.Y = e.Y;

            SensorMove();
        }

        private void MakeMove(MoveDirection direction)   // The method that implements the direction detection, if the direction was triggered,
        {                                               //  then the sound of movement is triggered, the analysis of the position of the blocks, 
                                                       // and the color change when merging.
            bool wasMove = false;                  
            
            switch (direction)                             
            {
                case MoveDirection.Left:
                    wasMove = MoveLeft();
                    break;
                case MoveDirection.Right:
                    wasMove = MoveRight();
                    break;
                case MoveDirection.Up:
                    wasMove = MoveUp();
                    break;
                case MoveDirection.Down:
                    wasMove = MoveDown();
                    break;
                default:
                    break;
            }

            if (wasMove)
            {
                AddCell();
                ColorCells();
                
                _animation_tick = 0;
                
                timer_anim.Start();
            }
        }

        private void SensorMove()  // Calls the motion implementation methods.
        {
            if (Math.Abs(_up_point.X - _down_point.X) < Math.Abs(_up_point.Y - _down_point.Y))
            {
                if (_up_point.Y < _down_point.Y)
                    MakeMove(MoveDirection.Up);
                else
                    MakeMove(MoveDirection.Down);
            }
            else
            {
                if (_up_point.X < _down_point.X)
                    MakeMove(MoveDirection.Left);
                else
                    MakeMove(MoveDirection.Right);
            }
        }
        #endregion

        #region Menu control.
        class GameState
        {
            public int[][] field { get; set; }

            public GameState()
            {
                field = new int[4][];

                for (int i = 0; i < 4; i++)
                    field[i] = new int[4];
            }
        }

        private void exit_menu_item_Click(object sender, EventArgs e) 
        {
            if (DialogResult.Yes == MessageBox.Show("Realy?", "Confirm", MessageBoxButtons.YesNo))
                Close(); 
        }

        private void topmost_menu_Click(object sender, EventArgs e) { this.TopMost = topmost_menu.Checked; }

        private void new_menu_Click(object sender, EventArgs e) { Map_Load(sender, e); }

        private void save_menu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "savegame.json";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.Write(JsonSerializer.Serialize(_state));
                }
            }
        }

        private void open_menu_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "savegame.json";
            openFileDialog1.Filter = "JSON files|*.json|All files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                MessageBox.Show(openFileDialog1.FileName);
        }
        #endregion
    }
}