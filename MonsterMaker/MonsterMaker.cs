using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterMaker
{
    public partial class MakerForm : Form
    {
        List<string> monster_types = new List<string>{ "Dino", "Golem", "Tiger", "Pixie", "Worm", "Jell", "Suezo", "Hare", "Gali", "Monol", "Naga", "Plant" };
        int[] power = { 120, 180, 80, 100, 120, 120, 120, 140, 130, 150, 150, 120, 130, 180, 120, 110, 130, 120, 130, 150, 140, 140, 180, 130, 100, 150, 90, 80, 100, 90, 100, 120, 110, 110, 130, 100, 120, 150, 90, 80, 100, 90, 100, 120, 110, 110, 150, 100, 120, 170, 110, 100, 120, 110, 120, 140, 130, 130, 160, 120, 100, 150, 90, 80, 100, 90, 100, 120, 150, 110, 130, 120, 120, 170, 110, 100, 120, 110, 120, 140, 130, 130, 150, 120, 130, 180, 120, 110, 130, 120, 130, 150, 140, 140, 160, 130, 120, 170, 110, 100, 120, 110, 120, 140, 130, 130, 150, 120, 120, 170, 110, 100, 120, 110, 120, 140, 130, 130, 150, 120, 130, 180, 120, 110, 130, 120, 130, 150, 140, 140, 160, 130, 100, 150, 90, 80, 100, 90, 100, 120, 110, 110, 130, 100 };
        int[] life = { 100, 100, 80, 60, 120, 90, 90, 80, 110, 110, 110, 150, 100, 100, 80, 60, 130, 100, 110, 80, 110, 110, 110, 150, 100, 100, 80, 60, 120, 100, 90, 80, 110, 110, 110, 150, 90, 90, 70, 50, 110, 90, 80, 70, 100, 100, 100, 140, 120, 120, 100, 80, 140, 120, 110, 100, 150, 130, 130, 170, 100, 100, 80, 60, 120, 100, 90, 80, 110, 110, 110, 150, 90, 90, 70, 50, 110, 90, 80, 70, 100, 100, 100, 140, 90, 90, 70, 50, 110, 90, 80, 70, 100, 100, 100, 140, 100, 100, 80, 60, 120, 100, 90, 80, 110, 110, 110, 150, 100, 100, 80, 60, 120, 100, 90, 80, 110, 110, 110, 150, 100, 100, 80, 60, 120, 100, 90, 80, 110, 110, 110, 150, 130, 130, 110, 90, 150, 130, 120, 110, 140, 140, 140, 180 };
        int[] def = { 100, 110, 100, 80, 100, 130, 100, 90, 120, 150, 110, 120, 120, 140, 110, 100, 130, 140, 120, 110, 130, 150, 130, 130, 90, 100, 80, 70, 90, 110, 90, 80, 100, 120, 100, 100, 90, 120, 70, 70, 90, 130, 90, 90, 100, 140, 110, 100, 100, 110, 90, 80, 100, 120, 100, 90, 80, 150, 110, 110, 120, 130, 110, 100, 120, 140, 120, 110, 130, 150, 130, 130, 100, 110, 90, 80, 100, 120, 100, 90, 110, 130, 110, 110, 90, 100, 80, 70, 90, 110, 90, 80, 100, 120, 100, 100, 120, 130, 110, 100, 120, 140, 120, 110, 130, 150, 130, 130, 130, 140, 120, 110, 130, 150, 130, 120, 140, 160, 140, 140, 120, 130, 110, 100, 120, 140, 120, 110, 130, 150, 130, 130, 100, 130, 90, 80, 100, 120, 100, 90, 110, 130, 110, 110 };
        int[] skill = { 140, 80, 160, 150, 130, 130, 140, 110, 150, 130, 150, 140, 110, 70, 130, 120, 130, 100, 110, 120, 150, 110, 130, 110, 140, 100, 160, 150, 130, 130, 140, 150, 150, 140, 150, 140, 130, 90, 150, 140, 120, 120, 130, 130, 140, 130, 140, 130, 130, 90, 150, 140, 120, 120, 130, 140, 140, 130, 140, 130, 130, 90, 150, 140, 120, 120, 130, 140, 140, 130, 140, 130, 130, 90, 150, 140, 120, 120, 130, 140, 140, 130, 140, 130, 130, 90, 150, 140, 120, 120, 130, 140, 140, 130, 140, 130, 110, 70, 130, 120, 100, 100, 110, 120, 120, 110, 120, 110, 110, 70, 130, 120, 100, 100, 110, 120, 120, 110, 120, 110, 140, 100, 160, 150, 130, 130, 140, 150, 150, 140, 150, 140, 130, 90, 150, 140, 120, 120, 130, 140, 140, 130, 140, 130 };
        int[] spd = { 100, 80, 140, 130, 90, 100, 100, 100, 120, 120, 110, 110, 90, 70, 110, 120, 110, 90, 90, 90, 100, 100, 100, 100, 120, 100, 140, 150, 110, 120, 120, 120, 130, 130, 130, 130, 130, 110, 150, 160, 120, 130, 130, 100, 140, 140, 140, 140, 90, 70, 110, 120, 80, 90, 90, 90, 100, 100, 100, 100, 90, 70, 110, 120, 80, 90, 120, 90, 100, 100, 100, 100, 100, 80, 120, 130, 90, 100, 100, 100, 110, 110, 110, 110, 120, 100, 140, 150, 110, 120, 120, 120, 130, 130, 130, 130, 100, 80, 120, 130, 90, 100, 100, 100, 110, 110, 110, 110, 100, 80, 120, 130, 90, 100, 100, 100, 110, 110, 110, 110, 100, 80, 120, 130, 90, 100, 100, 100, 110, 110, 110, 110, 100, 80, 120, 130, 90, 100, 100, 100, 110, 110, 110, 110 };
        int[] intel = { 100, 100, 100, 140, 100, 100, 110, 140, 130, 110, 40, 120, 120, 120, 120, 190, 100, 120, 130, 120, 150, 110, 40, 140, 120, 120, 120, 160, 120, 120, 130, 120, 150, 130, 70, 140, 130, 130, 130, 170, 130, 130, 140, 130, 160, 140, 160, 150, 120, 120, 120, 160, 120, 120, 130, 120, 150, 130, 60, 140, 130, 130, 130, 170, 130, 130, 140, 130, 160, 140, 80, 150, 130, 130, 130, 170, 130, 130, 140, 130, 160, 140, 80, 150, 120, 120, 120, 160, 120, 120, 130, 120, 150, 130, 70, 140, 130, 130, 130, 190, 130, 130, 140, 130, 160, 140, 80, 150, 120, 120, 120, 160, 120, 120, 130, 120, 170, 130, 70, 140, 90, 90, 90, 130, 90, 90, 130, 90, 120, 100, 40, 110, 120, 120, 120, 160, 120, 120, 130, 120, 150, 130, 70, 140 };
        int[] guts = { 13, 15, 12, 11, 13, 13, 13, 13, 14, 14, 13, 13, 18, 18, 17, 16, 18, 18, 18, 18, 19, 19, 19, 18, 9, 11, 9, 9, 9, 9, 9, 9, 10, 10, 9, 9, 7, 9, 6, 7, 7, 7, 7, 7, 8, 8, 7, 7, 15, 17, 14, 13, 15, 15, 15, 15, 16, 16, 15, 15, 14, 16, 13, 12, 14, 14, 14, 14, 15, 15, 14, 14, 12, 14, 11, 10, 12, 12, 12, 12, 13, 13, 12, 12, 10, 12, 9, 8, 10, 10, 10, 10, 11, 11, 10, 10, 16, 18, 15, 14, 16, 16, 16, 16, 17, 17, 16, 16, 17, 19, 16, 15, 17, 17, 17, 17, 18, 18, 17, 17, 11, 13, 10, 9, 11, 12, 11, 11, 12, 12, 11, 11, 8, 10, 7, 6, 8, 8, 8, 8, 8, 9, 8, 8 };
        int[] nat = { 55, 55, 65, 45, 55, 55, 35, 55, 55, 35, 40, 60, 65, 65, 65, 85, 70, 55, 65, 75, 65, 70, 50, 90, 50, 60, 70, 45, 70, 70, 75, 80, 65, 70, 30, 70, 40, 50, 75, 40, 50, 40, 40, 60, 70, 60, 40, 65, 60, 60, 60, 60, 60, 60, 60, 45, 70, 60, 40, 60, 50, 40, 50, 50, 50, 50, 80, 65, 60, 50, 25, 50, 35, 35, 40, 45, 45, 35, 35, 40, 35, 30, 35, 35, 55, 55, 75, 45, 55, 55, 50, 55, 40, 45, 70, 80, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 45, 35, 50, 55, 40, 45, 30, 30, 30, 40, 40, 30, 45, 25, 50, 75, 15, 65, 50, 30, 20, 15, 40, 30, 40, 65, 75, 85, 55, 40, 60, 25, 60, 70, 75, 50, 80 };

        int[] pow_seed = { 0, 7, -8, 9, 7, 10, 21, 7, -1, 8, 29, 2, 1, 3, 12, -13, 8, 8, 6, 4, 8, 8, -3, 2, 4, 10, 12, 8, 8, -3, 2, 7, 6, 5, 2, 1, -4, 0, 3, 9, 1, 2, 4, -5, 2, 6, 7, 8, 9, 3, -3, 7, 8, 4, 1, 9, 6, -7, 1, 0 };
        int[] life_seed = { 0, -2, 7, 6, 8, 5, 6, -5, 7, 1, 10, 18, 11, 14, -13, 15, 16, 17, 11, 19, 12, -17, 16, 18, 15, 16, 15, 17, -11, 10, 18, 11, 19, 15, 12, -16, 16, 17, 12, 18, 25, 26, -15, 27, 21, 20, 28, 21, 24, -13, 25, 26, 27, 21, 26, 25, -17, 21, 20, 28 };
        int[] def_seed = { 0, 4, 5, -1, 7, 9, 5, 1, 10, -1, 4, 7, 0, 5, 4, 6, -4, 6, 1, 1, 10, 7, 8, -9, 7, 10, 21, 7, 1, 8, -19, 2, 1, 3, 12, 13, 8, -8, 6, 4, 4, 4, 2, 1, -1, 4, 5, 7, 8, 9, 7, -4, 1, 4, 1, 2, 1, 1, -7, 8 };
        int[] ski_seed = { 0, 4, 8, 4, -4, 1, 1, 1, 1, 1, -4, 2, 2, 2, 2, 1, 1, -3, 3, 3, 3, 4, 18, 4, -1, 7, 8, 9, 8, 7, 4, -1, 1, 0, 8, 1, 7, 1, -9, 8, 10, 7, 8, 9, 7, -10, 21, 7, 1, 8, 29, 2, -1, 3, 12, 13, 8, 8, 6, -4 };
        int[] spd_seed = { 0, 6, 6, 8, 6, -9, 0, 0, 6, 8, 8, -8, 9, 5, 18, 5, 5, 5, -5, 1, 3, 3, 15, 2, 4, -2, 1, 8, 9, 14, 5, 5, -4, 1, 1, 5, 5, 3, 11, -1, 7, 8, 8, 4, 4, 1, -5, 5, 1, 5, 6, 4, 5, -11, 5, 8, 4, 17, 5, 4 };
        int[] int_seed = { 0, 1, 2, 3, 4, 5, -6, 7, 8, 9, 10, 11, -12, 13, 14, 15, 16, 17, 18, -19, 0, 1, 2, 3, 4, 5, -6, 7, 8, 9, 10, 11, 12, -13, 14, 15, 16, 17, 18, 19, 0, 1, 2, 3, 4, 5, 6, -7, -8, 9, 10, 11, 12, 13, -14, 15, 16, 17, 18, 19 };
        int[] subtype = { 1, 3, 1, 1, 9, 6, 5, 4, 9, 11, 11, 10, 7, 8, 6, 4, 6, 2, 6, 9, 4, 1, 0, 3, 7, 2, 10, 2, 5, 7, 8, 5, 10, 9, 1, 6, 11, 10, 7, 8, 1, 3, 10, 5, 0, 4, 7, 2, 9, 2, 4, 11, 0, 3, 0, 8, 5, 11, 0, 3 };

        int[] primary = { 0, 5, 1, 36, 31, 2, 11, 16, 28, 6, 8, 38 }; //Minimum number of extra minutes to get a monster of this type

        const int BYTES_PER_SECTOR = 2352; //Sector size for CDs in Bytes
        const int BYTES_PER_SECOND = 75*BYTES_PER_SECTOR;
        const int BYTES_PER_MINUTE = BYTES_PER_SECOND * 60;
        const int LEAD_IN = 2 * BYTES_PER_SECOND; //Standard lead-in time

        public MakerForm()
        {
            InitializeComponent();
            for (int i = 0; i < monster_types.Count; i++)
            {
                type1Box.Items.Add(monster_types[i]);
            }
            type1Box.SelectedIndex = 0;

            subtypeLabel.Text = monster_types[subtype[(int)seed2Box.Value]];
            UpdateTable();
        }

        private void UpdateTable() //Updates the table with relevant info
        {
            statsView.Rows.Clear();
            int seed1 = (int)seed1Box.Value;
            int seed2 = (int)seed2Box.Value;
            int type1 = type1Box.SelectedIndex;
            int type2 = subtype[seed2];
            int mytype = type1 * 12 + type2;

            

            statsView.Rows.Add(new object[5] { "Life", life[mytype], life_seed[seed1],life_seed[seed2],life[mytype]+life_seed[seed1]+life_seed[seed2] });
            statsView.Rows.Add(new object[5] { "Power", power[mytype], pow_seed[seed1], pow_seed[seed2], power[mytype] + pow_seed[seed1] + pow_seed[seed2] });
            statsView.Rows.Add(new object[5] { "Defense", def[mytype], def_seed[seed1], def_seed[seed2], def[mytype] + def_seed[seed1] + def_seed[seed2] });
            statsView.Rows.Add(new object[5] { "Skill", skill[mytype], ski_seed[seed1], ski_seed[seed2], skill[mytype] + ski_seed[seed1] + ski_seed[seed2] });
            statsView.Rows.Add(new object[5] { "Speed", spd[mytype], spd_seed[seed1], spd_seed[seed2], spd[mytype] + spd_seed[seed1] + spd_seed[seed2] });
            statsView.Rows.Add(new object[5] { "Intellect", intel[mytype], int_seed[seed1], int_seed[seed2], intel[mytype] + int_seed[seed1] + int_seed[seed2] });
            statsView.Rows.Add(new object[5] { "Guts", guts[mytype], "", "", guts[mytype]});
            statsView.Rows.Add(new object[5] { "Nature", nat[mytype], "", "", nat[mytype]});
        }

        private void type1Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void seed1Box_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void seed2Box_ValueChanged(object sender, EventArgs e)
        {
            subtypeLabel.Text = monster_types[subtype[(int)seed2Box.Value]];
            UpdateTable();
        }

        private void browseButton_Click(object sender, EventArgs e) //Sets filename
        {
            //SaveFileDialog getfile = new SaveFileDialog();

            DialogResult result = saveFile.ShowDialog();

            if(result == DialogResult.OK)
            {
                //if(!saveFile.FileName.EndsWith(".cue"))
                //    fileBox.Text = saveFile.FileName+ ".cue";
                //else
                    fileBox.Text = saveFile.FileName;
            }
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            if (fileBox.Text == null)
            {
                MessageBox.Show("No file selected!");
                return;
            }

            MakeCue(fileBox.Text);

            MakeBin(fileBox.Text);
        }

        private void MakeBin(string text)
        {
            string filename = text + ".bin";
            try
            {
                using (FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    stream.Write(new byte[BYTES_PER_MINUTE-LEAD_IN], 0, BYTES_PER_MINUTE-LEAD_IN); //Initial 5 minutes of CD space; chosen arbitrarily
                    stream.Write(new byte[BYTES_PER_MINUTE], 0, BYTES_PER_MINUTE);
                    stream.Write(new byte[BYTES_PER_MINUTE], 0, BYTES_PER_MINUTE);
                    stream.Write(new byte[BYTES_PER_MINUTE], 0, BYTES_PER_MINUTE);
                    stream.Write(new byte[BYTES_PER_MINUTE], 0, BYTES_PER_MINUTE);

                    for (int i = 0; i < seed1Box.Value; i++) //Add seconds to match the selected Stat Seed 1
                    {
                        stream.Write(new byte[BYTES_PER_SECOND], 0, BYTES_PER_SECOND);
                    }

                    for(int i = 0; i < primary[type1Box.SelectedIndex]; i++) //Add additional minutes to get the correct monster type
                    {
                        stream.Write(new byte[BYTES_PER_MINUTE], 0, BYTES_PER_MINUTE);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Failed to write to file!");
                MessageBox.Show("Failed to write .bin! Are you using the file in another program?");
            }
        }

        private void MakeCue(string text)
        {
            string filename = text + ".cue";
            try
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@filename))
                {
                    file.WriteLine(string.Format("FILE \"{0}\" BINARY", text + ".bin")); //Initialize a basic .cue file
                    file.WriteLine("  TRACK 01 AUDIO");
                    file.WriteLine("    INDEX 01 00:00:00");
                    file.WriteLine("  TRACK 02 AUDIO");
                    file.WriteLine("    INDEX 01 00:{0:00}:00", ((int)seed2Box.Value - 2 + 60) % 60); //Set 2nd track seconds to match stat seed 2
                    file.WriteLine("  TRACK 03 AUDIO");
                    file.WriteLine("    INDEX 01 01:00:00");
                    file.WriteLine("  TRACK 04 AUDIO");
                    file.WriteLine("    INDEX 01 02:00:00");
                    file.WriteLine("  TRACK 05 AUDIO");
                    file.WriteLine("    INDEX 01 03:00:00");
                }
            }
            catch
            {
                Console.WriteLine("Failed to write to file!");
                MessageBox.Show("Failed to write .cue! Are you using the file in another program?");
            }
        }
    }
}
