namespace TP14_JeudelaVie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuEtatVitesse = new System.Windows.Forms.MenuStrip();
            this.etatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.middleSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.squareModel = new System.Windows.Forms.PictureBox();
            this.squareModelAlive = new System.Windows.Forms.PictureBox();
            this.menuEtatVitesse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squareModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareModelAlive)).BeginInit();
            this.SuspendLayout();
            // 
            // menuEtatVitesse
            // 
            this.menuEtatVitesse.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEtatVitesse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etatToolStripMenuItem,
            this.vitesseToolStripMenuItem});
            this.menuEtatVitesse.Location = new System.Drawing.Point(0, 0);
            this.menuEtatVitesse.Name = "menuEtatVitesse";
            this.menuEtatVitesse.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuEtatVitesse.Size = new System.Drawing.Size(391, 24);
            this.menuEtatVitesse.TabIndex = 0;
            this.menuEtatVitesse.Text = "menuStrip1";
            // 
            // etatToolStripMenuItem
            // 
            this.etatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.etatToolStripMenuItem.Name = "etatToolStripMenuItem";
            this.etatToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.etatToolStripMenuItem.Text = "State";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "Start";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Exit";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // vitesseToolStripMenuItem
            // 
            this.vitesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lentToolStripMenuItem,
            this.middleSpeedToolStripMenuItem,
            this.rapideToolStripMenuItem});
            this.vitesseToolStripMenuItem.Name = "vitesseToolStripMenuItem";
            this.vitesseToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vitesseToolStripMenuItem.Text = "Speed";
            // 
            // lentToolStripMenuItem
            // 
            this.lentToolStripMenuItem.Name = "lentToolStripMenuItem";
            this.lentToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.lentToolStripMenuItem.Text = "Slow";
            this.lentToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // middleSpeedToolStripMenuItem
            // 
            this.middleSpeedToolStripMenuItem.Name = "middleSpeedToolStripMenuItem";
            this.middleSpeedToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.middleSpeedToolStripMenuItem.Text = "Medium";
            this.middleSpeedToolStripMenuItem.Click += new System.EventHandler(this.normalSpeedToolStripMenuItem_Click);
            // 
            // rapideToolStripMenuItem
            // 
            this.rapideToolStripMenuItem.Name = "rapideToolStripMenuItem";
            this.rapideToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rapideToolStripMenuItem.Text = "Quick";
            this.rapideToolStripMenuItem.Click += new System.EventHandler(this.quickToolStripMenuItem_Click);
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // squareModel
            // 
            this.squareModel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.squareModel.Location = new System.Drawing.Point(65, 78);
            this.squareModel.Name = "squareModel";
            this.squareModel.Size = new System.Drawing.Size(18, 19);
            this.squareModel.TabIndex = 1;
            this.squareModel.TabStop = false;
            // 
            // squareModelAlive
            // 
            this.squareModelAlive.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.squareModelAlive.Location = new System.Drawing.Point(121, 78);
            this.squareModelAlive.Name = "squareModelAlive";
            this.squareModelAlive.Size = new System.Drawing.Size(18, 19);
            this.squareModelAlive.TabIndex = 2;
            this.squareModelAlive.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 244);
            this.Controls.Add(this.squareModelAlive);
            this.Controls.Add(this.squareModel);
            this.Controls.Add(this.menuEtatVitesse);
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuEtatVitesse.ResumeLayout(false);
            this.menuEtatVitesse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squareModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareModelAlive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEtatVitesse;
        private System.Windows.Forms.ToolStripMenuItem etatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem middleSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapideToolStripMenuItem;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.PictureBox squareModel;
        private System.Windows.Forms.PictureBox squareModelAlive;
    }
}

