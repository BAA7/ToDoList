using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Models;

namespace ToDoList
{
    public partial class TaskTemplate : UserControl
    {
        public Control nameLabel;
        public Control deadlineLabel;
        public Control idLabel;
        public event Action<string, Data.TaskState> OnTaskChanged;
        public TaskTemplate()
        {
            InitializeComponent();
            nameLabel = this.Controls.Find("name", false)[0];
            deadlineLabel = this.Controls.Find("deadline", false)[0];
            idLabel = new Label();
            idLabel.Location = new Point(0, 0);
            idLabel.Visible = false;
            this.Controls.Add(idLabel);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            AppDbContext appDbContext = new AppDbContext();
            TodoTask task = appDbContext.UpdateTaskState(Convert.ToInt32(idLabel.Text));
            if (task != null)
            {
                OnTaskChanged.Invoke(idLabel.Text, task.State);
            }
            else
            {
                OnTaskChanged.Invoke(idLabel.Text, Data.TaskState.Removed);
            }
        }
    }
}
