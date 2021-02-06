
namespace StopWatch
{
    partial class Timer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.TextBox();
            this.alert = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.TextBox();
            this.hour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(12, 174);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(170, 50);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.stop.Location = new System.Drawing.Point(232, 174);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(170, 50);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.Location = new System.Drawing.Point(300, 47);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(85, 80);
            this.second.TabIndex = 2;
            this.second.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            this.second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_KeyPress);
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Location = new System.Drawing.Point(146, 13);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(0, 13);
            this.alert.TabIndex = 3;
            // 
            // minute
            // 
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.minute.Location = new System.Drawing.Point(165, 47);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(85, 80);
            this.minute.TabIndex = 4;
            this.minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minute.TextChanged += new System.EventHandler(this.minute_TextChanged);
            this.minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minute_KeyPress);
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.hour.Location = new System.Drawing.Point(30, 47);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(85, 80);
            this.hour.TabIndex = 5;
            this.hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_KeyPress);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 236);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.second);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Timer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.TextBox minute;
        private System.Windows.Forms.TextBox hour;
    }
}

