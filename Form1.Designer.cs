namespace Tic_Tac_Toe_Game
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tableGame = new System.Windows.Forms.TableLayoutPanel();
            this.Box9 = new System.Windows.Forms.PictureBox();
            this.Box8 = new System.Windows.Forms.PictureBox();
            this.Box7 = new System.Windows.Forms.PictureBox();
            this.Box6 = new System.Windows.Forms.PictureBox();
            this.Box5 = new System.Windows.Forms.PictureBox();
            this.Box3 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.Box4 = new System.Windows.Forms.PictureBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tableGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(581, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // tableGame
            // 
            this.tableGame.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableGame.ColumnCount = 3;
            this.tableGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableGame.Controls.Add(this.Box9, 2, 2);
            this.tableGame.Controls.Add(this.Box8, 1, 2);
            this.tableGame.Controls.Add(this.Box7, 0, 2);
            this.tableGame.Controls.Add(this.Box6, 2, 1);
            this.tableGame.Controls.Add(this.Box5, 1, 1);
            this.tableGame.Controls.Add(this.Box3, 2, 0);
            this.tableGame.Controls.Add(this.Box1, 0, 0);
            this.tableGame.Controls.Add(this.Box4, 0, 1);
            this.tableGame.Controls.Add(this.Box2, 1, 0);
            this.tableGame.Location = new System.Drawing.Point(483, 106);
            this.tableGame.Name = "tableGame";
            this.tableGame.RowCount = 3;
            this.tableGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableGame.Size = new System.Drawing.Size(516, 395);
            this.tableGame.TabIndex = 2;
            // 
            // Box9
            // 
            this.Box9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box9.Image = ((System.Drawing.Image)(resources.GetObject("Box9.Image")));
            this.Box9.Location = new System.Drawing.Point(332, 271);
            this.Box9.Name = "Box9";
            this.Box9.Size = new System.Drawing.Size(179, 119);
            this.Box9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box9.TabIndex = 8;
            this.Box9.TabStop = false;
            this.Box9.Tag = "?";
            this.Box9.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box8
            // 
            this.Box8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box8.Image = ((System.Drawing.Image)(resources.GetObject("Box8.Image")));
            this.Box8.Location = new System.Drawing.Point(165, 271);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(159, 119);
            this.Box8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box8.TabIndex = 7;
            this.Box8.TabStop = false;
            this.Box8.Tag = "?";
            this.Box8.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box7
            // 
            this.Box7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box7.Image = ((System.Drawing.Image)(resources.GetObject("Box7.Image")));
            this.Box7.Location = new System.Drawing.Point(5, 271);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(152, 119);
            this.Box7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box7.TabIndex = 6;
            this.Box7.TabStop = false;
            this.Box7.Tag = "?";
            this.Box7.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box6
            // 
            this.Box6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box6.Image = ((System.Drawing.Image)(resources.GetObject("Box6.Image")));
            this.Box6.Location = new System.Drawing.Point(332, 138);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(179, 125);
            this.Box6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box6.TabIndex = 5;
            this.Box6.TabStop = false;
            this.Box6.Tag = "?";
            this.Box6.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box5
            // 
            this.Box5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box5.Image = ((System.Drawing.Image)(resources.GetObject("Box5.Image")));
            this.Box5.Location = new System.Drawing.Point(165, 138);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(159, 125);
            this.Box5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box5.TabIndex = 3;
            this.Box5.TabStop = false;
            this.Box5.Tag = "?";
            this.Box5.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box3
            // 
            this.Box3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box3.Image = ((System.Drawing.Image)(resources.GetObject("Box3.Image")));
            this.Box3.Location = new System.Drawing.Point(332, 5);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(179, 125);
            this.Box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box3.TabIndex = 3;
            this.Box3.TabStop = false;
            this.Box3.Tag = "?";
            this.Box3.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box1
            // 
            this.Box1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box1.Image = ((System.Drawing.Image)(resources.GetObject("Box1.Image")));
            this.Box1.Location = new System.Drawing.Point(5, 5);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(152, 125);
            this.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            this.Box1.Tag = "?";
            this.Box1.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box4
            // 
            this.Box4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box4.Image = ((System.Drawing.Image)(resources.GetObject("Box4.Image")));
            this.Box4.Location = new System.Drawing.Point(5, 138);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(152, 125);
            this.Box4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box4.TabIndex = 1;
            this.Box4.TabStop = false;
            this.Box4.Tag = "?";
            this.Box4.Click += new System.EventHandler(this.BoxClick);
            // 
            // Box2
            // 
            this.Box2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box2.Image = ((System.Drawing.Image)(resources.GetObject("Box2.Image")));
            this.Box2.Location = new System.Drawing.Point(165, 5);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(159, 125);
            this.Box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box2.TabIndex = 2;
            this.Box2.TabStop = false;
            this.Box2.Tag = "?";
            this.Box2.Click += new System.EventHandler(this.BoxClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(163, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Snap ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(125, 137);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(232, 55);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Player 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(137, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 60);
            this.label5.TabIndex = 6;
            this.label5.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblWinner.Location = new System.Drawing.Point(127, 359);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(215, 48);
            this.lblWinner.TabIndex = 7;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Yellow;
            this.btnRestart.Location = new System.Drawing.Point(146, 466);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(176, 67);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1022, 627);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableGame);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Tag = "false";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.tableGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableGame;
        private System.Windows.Forms.PictureBox Box9;
        private System.Windows.Forms.PictureBox Box8;
        private System.Windows.Forms.PictureBox Box7;
        private System.Windows.Forms.PictureBox Box6;
        private System.Windows.Forms.PictureBox Box5;
        private System.Windows.Forms.PictureBox Box3;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.PictureBox Box4;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
    }
}

