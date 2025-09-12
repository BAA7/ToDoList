namespace ToDoList
{
    partial class TaskTemplate
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            name = new Label();
            deadline = new Label();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name.Location = new Point(0, 9);
            name.Name = "name";
            name.Size = new Size(99, 25);
            name.TabIndex = 0;
            name.Text = "Task name";
            // 
            // deadline
            // 
            deadline.AutoSize = true;
            deadline.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deadline.Location = new Point(192, 9);
            deadline.Name = "deadline";
            deadline.Size = new Size(110, 25);
            deadline.TabIndex = 1;
            deadline.Text = "dd.mm.yyyy";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = SystemColors.Control;
            updateBtn.Location = new Point(308, 13);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(36, 23);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "‪✓";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // TaskTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(updateBtn);
            Controls.Add(deadline);
            Controls.Add(name);
            Name = "TaskTemplate";
            Size = new Size(360, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label deadline;
        private Button updateBtn;
    }
}
