using System.Threading;

namespace MultiTheards
{
    public partial class Form1 : Form
    {
        private Dictionary<object, CancellationTokenSource> tasksList = new Dictionary<object, CancellationTokenSource>();
        private Random random = new Random();
        bool isDrawing = false;
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxList();
        }

        private void InitializeComboBoxList()
        {
            comboBox1.DataSource = OperationList.GetValues(typeof(OperationList));
            comboBox2.DataSource = OperationList.GetValues(typeof(OperationList));
            comboBox3.DataSource = OperationList.GetValues(typeof(OperationList));
            comboBox4.DataSource = OperationList.GetValues(typeof(OperationList));
            ShowAvaibleThreads();
        }

        private void ShowAvaibleThreads()
        {
            int workerThreads, completionPortThreads;
            ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);
            AvaibleThreadsLabel.Text = $"Liczba dostêpnych w¹tków: {workerThreads}";
        }
        #region threadButtonsEvents
        private async void Thread_Click(object sender, EventArgs e)
        {
            //stops buttons
             var s = sender as Button;
            s.Enabled = false;
            if (sender == StopThread1)
            {
                CancellationTokenSource cts = tasksList.GetValueOrDefault(RunThread1);
                cts.Cancel();
                tasksList.Remove(RunThread1);
            }
            if (sender == StopThread2)
            {
                CancellationTokenSource cts = tasksList.GetValueOrDefault(RunThread2);
                cts.Cancel();
                tasksList.Remove(RunThread2);
            }
            if (sender == StopThread3)
            {
                CancellationTokenSource cts = tasksList.GetValueOrDefault(RunThread3);
                cts.Cancel();
                tasksList.Remove(RunThread3);
            }
            if (sender == StopThread4)
            {
                CancellationTokenSource cts = tasksList.GetValueOrDefault(RunThread4);
                cts.Cancel();
                tasksList.Remove(RunThread4);
            }
            // starts buttons
            if (sender == RunThread1)
            {
                comboBox1.Enabled = false;
                RunThread1.Enabled = false;
                StopThread1.Enabled = true;
                if (await RunCalculation(sender, (OperationList)comboBox1.SelectedItem))
                {
                    comboBox1.Enabled = true;
                    StopThread1.Enabled = false;
                    RunThread1.Enabled = true;
                }
            }
            if (sender == RunThread2)
            {
                StopThread2.Enabled = true;
                comboBox2.Enabled = false;
                RunThread2.Enabled = false;
                if (await RunCalculation(sender, (OperationList)comboBox2.SelectedItem))
                {
                    RunThread2.Enabled = true;
                    comboBox2.Enabled = true;
                    StopThread2.Enabled = false;
                }
            }
            if (sender == RunThread3)
            {
                StopThread3.Enabled = true;
                comboBox3.Enabled = false;
                RunThread3.Enabled = false;
                if (await RunCalculation(sender, (OperationList)comboBox3.SelectedItem))
                {
                    comboBox3.Enabled = true;
                    RunThread3.Enabled = true;
                    StopThread3.Enabled = false;
                }
            }
            if (sender == RunThread4)
            {
                comboBox4.Enabled = false;
                RunThread4.Enabled = false;
                StopThread4.Enabled = true;
                if (await RunCalculation(sender, (OperationList)comboBox4.SelectedItem))
                {
                    comboBox4.Enabled = true;
                    RunThread4.Enabled = true;
                    StopThread4.Enabled = false;
                }
            }
        }
        #endregion
        private async Task<bool> RunCalculation(object sender, OperationList selected)
        {
            Task task = null;
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken ct = tokenSource.Token;
            Action action = null;
            switch (selected)
            {
                case OperationList.Counter:
                    action = new Action(delegate
                    {
                        RunCounterAsync(task.Id, ct);
                    });
                    break;
                case OperationList.Draw:
                    if (isDrawing)
                    {
                        MessageBox.Show("Nie mozna uruchomic 2 w¹tków rysowania na raz!");
                        return true;
                    }
                    action = new Action(delegate
                    {
                        DrawImageAsync(task.Id, ct);
                    });
                    break;
                case OperationList.InfiniteFibonaci:
                    action = new Action(delegate
                    {
                        InfiniteFibonaci(task.Id, ct);
                    });
                    break;
            }
            task = new Task(action, ct);
            bool isCompleted = false;
            if (task != null)
            {
                task.Start();
                tasksList.Add(sender, tokenSource);
                ShowAvaibleThreads();
                await task;
                if (task.IsCompleted)
                {
                    isCompleted = true;
                }
                tasksList.Remove(sender);
                task.Dispose();
                ShowAvaibleThreads();
            }
            return isCompleted;
        }
        #region operations
        private void RunCounterAsync(int id, CancellationToken ct)
        {
            for (int i = 0; i < 100; i++)
            {
                if (ct.IsCancellationRequested)
                {
                    break;
                }
                textBox1.Invoke(new Action(() =>
                {
                    textBox1.AppendText($" {i} \n");

                }));
                Thread.Sleep(100);
                PrintLog($"Thread {id} is counting");
            }
        }

        private void InfiniteFibonaci(int id, CancellationToken ct)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                if (ct.IsCancellationRequested)
                {
                    break;
                }
                int fb = Fibonacci(i);
                textBox1.Invoke(new Action(delegate
                {
                    textBox1.AppendText($"{Environment.NewLine}{i} element ciagu Fibonaciego to {fb} {Environment.NewLine}");
                }));
                PrintLog($"Thread {id} is calculating Fibonacci");

            }
        }
        public int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        private void PrintLog(string message)
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("yyyy-MM-dd HH:mm:ss");
            string preparedMessage = $"{formattedDateTime}  {message} {Environment.NewLine}";
            if (LoggerTextbox.InvokeRequired)
            {
                LoggerTextbox.Invoke(new Action(() =>
                {
                    if (!LoggerTextbox.Text.Contains(preparedMessage))
                    {
                        LoggerTextbox.AppendText(preparedMessage);
                    }
                }));
            }
            else
            {
                LoggerTextbox.AppendText(preparedMessage + Environment.NewLine);
            }
        }

        private async void DrawImageAsync(int id, CancellationToken ct)
        {
            isDrawing = true;
            Bitmap bitmapToDraw = new Bitmap("szymon.png");
            pictureBox1.Invoke(new Action(delegate ()
            {
                pictureBox1.Width = bitmapToDraw.Width;
                pictureBox1.Height = bitmapToDraw.Height;
            }));
            Dictionary<Color, Color> colors = new Dictionary<Color, Color>();
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int Xcount = 0; Xcount < bmp.Width; Xcount++)
            {
                for (int Ycount = 0; Ycount < bmp.Height; Ycount++)
                {
                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }
                    var pixel = bitmapToDraw.GetPixel(Xcount, Ycount);
                    if (!colors.ContainsKey(pixel))
                    {
                        colors.Add(pixel, GetRandomColor());
                    }
                    bmp.SetPixel(Xcount, Ycount, colors.GetValueOrDefault(pixel));
                    pictureBox1.Invoke(new Action(delegate ()
                    {
                        pictureBox1.Image = bmp;
                        pictureBox1.Refresh();
                    }));

                    PrintLog($"Thread {id} is drawing");
                }
            }
            PrintLog($"Thread {id} drew image");
            isDrawing = false;
        }

        public Color GetRandomColor()
        {
            byte[] rgb = new byte[3];
            random.NextBytes(rgb);
            Color color = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
            return color;
        }
        #endregion
        enum OperationList
        {
            Counter,
            Draw,
            InfiniteFibonaci
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var task in tasksList)
            {
                task.Value.Cancel();
            }
        }
    }
}