using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Models;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        private List<FlowLayoutPanel> flowLayoutPanels = new List<FlowLayoutPanel>();
        public MainForm()
        {
            InitializeComponent();
            Text = "To Do List";
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            TableLayoutPanel tasksPanel = new TableLayoutPanel();
            tasksPanel.Location = new Point(0, 0);
            tasksPanel.Size = new Size(this.Size.Width, this.Size.Height - 100);
            tasksPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tasksPanel.RowCount = 2;
            tasksPanel.ColumnCount = 3;
            for(int i=0; i < tasksPanel.ColumnCount; i++)
            {
                tasksPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            }
            tasksPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));
            tasksPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50f));

            List<String> columnNames = new List<String>() { "To do", "Active", "Completed"};
            for(int i = 0; i < 3; i++)
            {
                Label label = new Label();
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font(label.Font.FontFamily, 20f, FontStyle.Regular);
                label.Text = columnNames[i];
                tasksPanel.Controls.Add(label, i, 0);
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.AutoScroll = true;
                flowLayoutPanel.Dock = DockStyle.Fill;
                tasksPanel.Controls.Add(flowLayoutPanel, i, 1);
                flowLayoutPanels.Add(flowLayoutPanel);
            }
            this.Controls.Add(tasksPanel);

            Button addBtn = new();
            addBtn.Text = "Add";
            addBtn.Location = new Point(0, tasksPanel.Size.Height);
            addBtn.Name = "addBtn";
            addBtn.Click += addBtn_Click;
            this.Controls.Add(addBtn);
        }

        public void AddTask(TodoTask task)
        {
            TaskTemplate taskTemplate = new TaskTemplate();
            taskTemplate.nameLabel.Text = task.Name;
            taskTemplate.deadlineLabel.Text = task.Deadline.ToShortDateString();
            taskTemplate.idLabel.Text = task.Id.ToString();
            taskTemplate.BackColor = Data.PriorityColors[task.Priority];
            flowLayoutPanels[0].Controls.Add(taskTemplate);
            taskTemplate.OnTaskChanged += (taskId, taskState) =>
            {
                UpdateTask(taskId, taskState);
            };
        }

        public void UpdateTask(string taskId, Data.TaskState taskState)
        {
            TaskTemplate toMove;
            int flowPanelIdx;
            switch (taskState)
            {
                case Data.TaskState.Active:
                    flowPanelIdx = 0;
                    break;
                case Data.TaskState.Completed:
                    flowPanelIdx = 1;
                    break;
                default:
                    flowPanelIdx = 2;
                    break;
            }
            foreach(TaskTemplate template in flowLayoutPanels[flowPanelIdx].Controls)
            {
                if(template.idLabel.Text != taskId)
                {
                    continue;
                }
                if (flowPanelIdx == 2)
                {
                    flowLayoutPanels[flowPanelIdx].Controls.Remove(template);
                }
                else
                {
                    template.Parent = flowLayoutPanels[flowPanelIdx + 1];
                }
                break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.OnTaskCreated += (task) =>
            {
                AddTask(task);
            };
            addForm.ShowDialog(this);
        }
    }
}
