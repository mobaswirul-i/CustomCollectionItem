using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;
using Tizen.NUI.Binding;
using Tizen;

namespace SamsungAnalyticsUIApp
{
    class Program : NUIApplication
    {
        protected override void OnCreate()
        {
            // Logger.Start();
            base.OnCreate();
            Initialize();
            // Logger.End();
        }

        void OnInfoButtonClicked(object sender, EventArgs args)
        {
            // Logger.Start();
            // Logger.End();
        }

        void OnSearchButtonClicked(object sender, EventArgs args)
        {
            // Logger.Start();
            // Logger.End();
        }

        void OnUpdateButtonClicked(object sender, EventArgs args)
        {
            // Logger.Start();
            // Logger.End();
        }

        void OnMoreButtonClicked(object sender, EventArgs args)
        {
            // Logger.Start();
            // Logger.End();
        }

        void Initialize()
        {
            // Logger.Start();
            Window.Instance.KeyEvent += OnKeyEvent;

            // Overall View
            View top_view = new View();
            top_view.HeightResizePolicy = ResizePolicyType.FillToParent;
            top_view.WidthResizePolicy = ResizePolicyType.FillToParent;
            Window.Instance.GetDefaultLayer().Add(top_view);

            //topview layout
            LinearLayout top_view_Layout = new LinearLayout();
            top_view_Layout.LinearOrientation = LinearLayout.Orientation.Vertical;
            top_view_Layout.HorizontalAlignment = HorizontalAlignment.Center;
            top_view_Layout.VerticalAlignment = VerticalAlignment.Top;
            top_view.Layout = top_view_Layout;

            //adding component to top view --> Heading
            TextLabel text = new TextLabel("Samsung Analytics Log Viewer (Page/Event/Settings Logs)");
            text.HorizontalAlignment = HorizontalAlignment.Center;
            text.VerticalAlignment = VerticalAlignment.Top;
            text.TextColor = Color.White;
            //text.PointSize = 15.0f;
            top_view.Add(text);


            //adding component to top view --> View for Buttons
            View top_view_bt = new View();
            top_view_bt.HeightResizePolicy = ResizePolicyType.FitToChildren;
            top_view_bt.WidthResizePolicy = ResizePolicyType.FillToParent;
            top_view_bt.BackgroundColor = Color.Blue;
            top_view_bt.Padding = new Extents(50, 50, 50, 50);
            top_view.Add(top_view_bt);


            //topview_bt layout
            LinearLayout top_view_bt_Layout = new LinearLayout();
            top_view_bt_Layout.LinearOrientation = LinearLayout.Orientation.Horizontal;
            top_view_bt_Layout.HorizontalAlignment = HorizontalAlignment.Begin;
            top_view_bt_Layout.VerticalAlignment = VerticalAlignment.Top;
            top_view_bt_Layout.CellPadding = new Size2D(90, 90);
            top_view_bt.Layout = top_view_bt_Layout;

            //Info Button
            Button testButton_1 = new Button();
            testButton_1.Text = "Info";
            //testButton_1.HeightResizePolicy = ResizePolicyType.FillToParent;
            //testButton_1.WidthResizePolicy = ResizePolicyType.FillToParent;
            testButton_1.Clicked += OnInfoButtonClicked;
            top_view_bt.Add(testButton_1);


            // Search button
            Button testButton_2 = new Button();
            testButton_2.Text = "Search Logs";
            //testButton_2.HeightResizePolicy = ResizePolicyType.FillToParent;
            //testButton_2.WidthResizePolicy = ResizePolicyType.FillToParent;
            testButton_2.Color = Color.Green;
            testButton_2.Clicked += OnSearchButtonClicked;
            top_view_bt.Add(testButton_2);

            // Update button
            Button testButton_3 = new Button();
            testButton_3.Text = "Update Logs";
            //testButton_3.HeightResizePolicy = ResizePolicyType.FillToParent;
            //testButton_3.WidthResizePolicy = ResizePolicyType.FillToParent;
            testButton_3.Color = Color.Green;
            testButton_3.Clicked += OnUpdateButtonClicked;
            top_view_bt.Add(testButton_3);

            // More button
            Button testButton_4 = new Button();
            testButton_4.Text = "More Options";
            //testButton_4.HeightResizePolicy = ResizePolicyType.FillToParent;
            //testButton_4.WidthResizePolicy = ResizePolicyType.FillToParent;
            testButton_4.Color = Color.Green;
            testButton_4.Clicked += OnMoreButtonClicked;
            top_view_bt.Add(testButton_4);



            //// Adding ListView below top_view
            View listViewContainer = new View();
            listViewContainer.HeightResizePolicy = ResizePolicyType.FillToParent;
            listViewContainer.WidthResizePolicy = ResizePolicyType.FillToParent;
            listViewContainer.BackgroundColor = Color.Yellow;
            listViewContainer.Margin = new Extents(0, 0, 15, 10);
            top_view.Add(listViewContainer);

            //// ListView layout
            LinearLayout listViewLayout = new LinearLayout();
            listViewLayout.LinearOrientation = LinearLayout.Orientation.Vertical;
            listViewLayout.HorizontalAlignment = HorizontalAlignment.Begin;
            listViewLayout.VerticalAlignment = VerticalAlignment.Top;
            listViewContainer.Layout = listViewLayout;




            //// CollectionView--inside list view container
            CollectionView listview = new CollectionView();
            listview.ItemsLayouter = new LinearLayouter();
            listview.HeightSpecification = LayoutParamPolicies.MatchParent;
            listview.WidthSpecification = LayoutParamPolicies.MatchParent;
            listview.BackgroundColor = Color.White;
            listview.Margin = new Extents(10, 10, 10, 10);



            //// Sample data for ListView
            ListItemData[] items = new ListItemData[]
            {
                new ListItemData(1, "2023-10-01 12:34:56", "12345", "com.example.app", "Log details 1"),
                new ListItemData(2, "2023-10-02 13:45:67", "67890", "com.example.app2", "Log details 2"),
                new ListItemData(3, "2023-10-03 14:56:78", "98765", "com.example.app3", "Log details 3"),
                new ListItemData(4, "2023-10-04 15:67:89", "54321", "com.example.app4", "Log details 4"),
                new ListItemData(5, "2023-10-05 16:78:90", "87654", "com.example.app5", "Log details 5"),
                
                new ListItemData(11, "2023-10-01 12:34:56", "12345", "com.example.app", "Log details 11"),
                new ListItemData(12, "2023-10-02 13:45:67", "67890", "com.example.app2", "Log details 12"),
                new ListItemData(13, "2023-10-03 14:56:78", "98765", "com.example.app3", "Log details 13"),
                new ListItemData(14, "2023-10-04 15:67:89", "54321", "com.example.app4", "Log details 14"),
                new ListItemData(15, "2023-10-05 16:78:90", "87654", "com.example.app5", "Log details 15")
            };

            listview.ItemTemplate = new DataTemplate(() =>
            {
                CustomCollectionitem item = new CustomCollectionitem();
                item.SNo.SetBinding(TextLabel.TextProperty, "SNo");
                item.DateTime.SetBinding(TextLabel.TextProperty, "DateTime");
                item.Tid.SetBinding(TextLabel.TextProperty, "Tid");
                item.Package.SetBinding(TextLabel.TextProperty, "Package");
                item.LogDetails.SetBinding(TextLabel.TextProperty, "LogDetails");
                return item;
            });

            listview.ItemsSource = items;
            listview.SelectionChanged += OnSelectionChanged;


            listViewContainer.Add(listview);


            // Logger.End();
        }





        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Logger.Start();
            // Logger.End();
        }




        public void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            // Logger.Start();
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
            // Logger.End();
        }

        static void Main(string[] args)
        {
            // Logger.Start();
            var app = new Program();
            app.Run(args);
            // Logger.End();
        }
    }

    public class ListItemData
    {
        public int SNo { get; set; }
        public string DateTime { get; set; }
        public string Tid { get; set; }
        public string Package { get; set; }
        public string LogDetails { get; set; }

        public ListItemData(int sno, string datetime, string tid, string package, string logdetails)
        {
            SNo = sno;
            DateTime = datetime;
            Tid = tid;
            Package = package;
            LogDetails = logdetails;
        }
    }
}