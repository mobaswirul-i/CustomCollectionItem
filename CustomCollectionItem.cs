using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace SamsungAnalyticsUIApp
{
    class CustomCollectionitem : RecyclerViewItem
    {
        private TextLabel slNo;
        private TextLabel dateTime;
        private TextLabel pid;
        private TextLabel package;
        private TextLabel logDetails;

        private View mainView;
        private View itemSeperator;

        static CustomCollectionitem() { }
        public CustomCollectionitem() : base() { }

        public CustomCollectionitem(string style): base(style) { }

        public override void OnInitialize()
        {
            base.OnInitialize();
            Layout = new LinearLayout()
            {
                LinearOrientation = LinearLayout.Orientation.Vertical,
            };
            WidthResizePolicy = ResizePolicyType.FillToParent;
            SizeHeight = 105.SpToPx();
        }

        public override void ApplyStyle(ViewStyle viewStyle)
        {
            base.ApplyStyle(viewStyle);
        }

        public override void OnRelayout(Vector2 size, RelayoutContainer container)
        {
            LayoutChild();
            base.OnRelayout(size, container);
        }

        protected override string AccessibilityGetName()
        {
            return "{" + slNo.Text + ", " + dateTime.Text + ", " + pid.Text + ", " + package.Text + ", " + logDetails + "}";
        }

        private TextLabel CreateLabel()
        {
            return new TextLabel()
            {
                SizeHeight = 48.SpToPx(),
                Margin = new Extents(8,8,4,0).SpToPx()
            };
        }

        public TextLabel SNo
        {
            get
            {
                if (this.slNo == null)
                {
                    slNo = CreateLabel();
                }
                return slNo;
            }
            internal set
            {
                slNo = value;
            }
        }

        public TextLabel DateTime
        {
            get
            {
                if (this.dateTime== null)
                {
                    dateTime = CreateLabel();
                }
                return dateTime;
            }
            internal set
            {
                dateTime = value;
            }
        }

        public TextLabel Tid
        {
            get
            {
                if (this.pid == null)
                {
                    pid = CreateLabel();
                }
                return pid;
            }
            internal set
            {
                pid = value;
            }
        }

        public TextLabel Package
        {
            get
            {
                if (this.package == null)
                {
                    package = CreateLabel();
                }
                return package;
            }
            internal set
            {
                package = value;
            }
        }

        public TextLabel LogDetails
        {
            get
            {
                if (this.logDetails == null)
                {
                    logDetails = CreateLabel();
                }
                return logDetails;
            }
            internal set
            {
                logDetails = value;
            }
        }

        public View Seperator
        {
            get
            {
                if (itemSeperator == null)
                {
                    itemSeperator = new View()
                    {
                        WidthSpecification = LayoutParamPolicies.MatchParent,
                        HeightSpecification = 2,
                        BackgroundColor = Tizen.NUI.Color.Black,
                    };
                }
                return itemSeperator;
            }
        }

        protected override void LayoutChild()
        {
            View mainView = new View()
            {
                Layout = new LinearLayout()
                {
                    LinearOrientation = LinearLayout.Orientation.Vertical,
                },
                WidthSpecification = LayoutParamPolicies.MatchParent
            };
            View topView = new View()
            {
                Layout = new LinearLayout()
                {
                    LinearOrientation = LinearLayout.Orientation.Horizontal,
                },
                BackgroundColor = new Tizen.NUI.Color(1.0f, 0.0f, 0.0f, 0.0f)
            };

            if(slNo != null) topView.Add(slNo);
            if(dateTime != null) topView.Add(dateTime);
            if(pid != null) topView.Add(pid);
            if(package != null) topView.Add(package);

            mainView.Add(topView);
            if(logDetails != null) mainView.Add(logDetails);
            mainView.Add(Seperator);
            Add(mainView);
        }
    }
}
