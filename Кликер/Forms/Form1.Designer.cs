
namespace Кликер.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Click = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.improveWorkerButton = new System.Windows.Forms.Button();
			this.improveWorker = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.improveToolButton = new System.Windows.Forms.Button();
			this.improveTool = new System.Windows.Forms.Label();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.clear = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.points = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.updatechecker = new System.Windows.Forms.Timer(this.components);
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 506);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel2.Controls.Add(this.Click, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 2);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 256);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 247);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// Click
			// 
			this.Click.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Click.Location = new System.Drawing.Point(138, 85);
			this.Click.Name = "Click";
			this.Click.Size = new System.Drawing.Size(130, 76);
			this.Click.TabIndex = 0;
			this.Click.Text = "CLICK";
			this.Click.UseVisualStyleBackColor = true;
			this.Click.Click += new System.EventHandler(this.Point_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.improveWorkerButton, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.improveWorker, 0, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(274, 167);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(131, 77);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// improveWorkerButton
			// 
			this.improveWorkerButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.improveWorkerButton.Location = new System.Drawing.Point(3, 28);
			this.improveWorkerButton.Name = "improveWorkerButton";
			this.improveWorkerButton.Size = new System.Drawing.Size(125, 20);
			this.improveWorkerButton.TabIndex = 0;
			this.improveWorkerButton.Text = "Апгрейд рабочего";
			this.improveWorkerButton.UseVisualStyleBackColor = true;
			this.improveWorkerButton.Click += new System.EventHandler(this.ImproveWorkerButton_Click);
			// 
			// improveWorker
			// 
			this.improveWorker.AutoSize = true;
			this.improveWorker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.improveWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.improveWorker.Location = new System.Drawing.Point(3, 0);
			this.improveWorker.Name = "improveWorker";
			this.improveWorker.Size = new System.Drawing.Size(125, 25);
			this.improveWorker.TabIndex = 1;
			this.improveWorker.Text = "0x   100$";
			this.improveWorker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.improveToolButton, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.improveTool, 0, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(138, 167);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.76624F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(130, 77);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// improveToolButton
			// 
			this.improveToolButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.improveToolButton.Location = new System.Drawing.Point(3, 28);
			this.improveToolButton.Name = "improveToolButton";
			this.improveToolButton.Size = new System.Drawing.Size(124, 20);
			this.improveToolButton.TabIndex = 0;
			this.improveToolButton.Text = "Апгрейд клика";
			this.improveToolButton.UseVisualStyleBackColor = true;
			this.improveToolButton.Click += new System.EventHandler(this.ImproveToolButton_Click);
			// 
			// improveTool
			// 
			this.improveTool.AutoSize = true;
			this.improveTool.Dock = System.Windows.Forms.DockStyle.Fill;
			this.improveTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.improveTool.Location = new System.Drawing.Point(3, 0);
			this.improveTool.Name = "improveTool";
			this.improveTool.Size = new System.Drawing.Size(124, 25);
			this.improveTool.TabIndex = 1;
			this.improveTool.Text = "0x   10$";
			this.improveTool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.clear, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.button1, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.button2, 0, 1);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 167);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.76624F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.76624F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(129, 77);
			this.tableLayoutPanel5.TabIndex = 3;
			// 
			// clear
			// 
			this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clear.Location = new System.Drawing.Point(3, 55);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(123, 19);
			this.clear.TabIndex = 0;
			this.clear.Text = "Выход";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.Exit_Click);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "Достижения";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.TransitionAchievements);
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 3;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.1778F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.6444F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.1778F));
			this.tableLayoutPanel6.Controls.Add(this.points, 1, 1);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 3;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(408, 247);
			this.tableLayoutPanel6.TabIndex = 1;
			// 
			// points
			// 
			this.points.AutoSize = true;
			this.points.Dock = System.Windows.Forms.DockStyle.Fill;
			this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.points.Location = new System.Drawing.Point(77, 82);
			this.points.Name = "points";
			this.points.Size = new System.Drawing.Size(253, 82);
			this.points.TabIndex = 0;
			this.points.Text = "0$";
			this.points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// updatechecker
			// 
			this.updatechecker.Enabled = true;
			this.updatechecker.Tick += new System.EventHandler(this.updatechecker_Tick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 85);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(129, 76);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.Location = new System.Drawing.Point(3, 29);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 20);
			this.button2.TabIndex = 0;
			this.button2.Text = "Настройки";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(414, 506);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Кликер";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForms);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Click;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button improveWorkerButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button improveToolButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label improveWorker;
        private System.Windows.Forms.Label improveTool;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer updatechecker;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

