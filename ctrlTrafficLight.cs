using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light_Project.Properties;

namespace Traffic_Light_Project
{
    public partial class ctrlTrafficLight : UserControl
    {

        public enum enLight { Red =1 , Oragne = 2 , Green = 3 };


        private enLight _CurrentLight = enLight.Red;

        public class TrafficLightEventArg : EventArgs
        { 
            public enLight CurrentLight { get; }
            public int Time { get; }

            public TrafficLightEventArg(enLight currentLight, int time)
            {
                CurrentLight = currentLight;
                Time = time;
            }
        }



        public event EventHandler<TrafficLightEventArg> RedLightOn; 

        public void RaiseRedLightOn()
        {
            RedLightOn?.Invoke(this, new TrafficLightEventArg(enLight.Red , RedTime));
        }


          public event EventHandler<TrafficLightEventArg> GreenLightOn; 

        public void RaiseGreenLightOn()
        {
            RedLightOn?.Invoke(this, new TrafficLightEventArg(enLight.Green , GreenTime));
        }

           public event EventHandler<TrafficLightEventArg> OrangeLightOn; 

        public void RaiseOrangeLightOn()
        {
            RedLightOn?.Invoke(this, new TrafficLightEventArg(enLight.Oragne, OrangeTime));
        }

        public event EventHandler<TrafficLightEventArg> RedLightOff;

        public void RaiseRedLightOff()
        {
            RedLightOff?.Invoke(this, new TrafficLightEventArg(enLight.Red , RedTime));
        }


          public event EventHandler<TrafficLightEventArg> GreenLightOff; 

        public void RaiseGreenLightOff()
        {
            RedLightOff?.Invoke(this, new TrafficLightEventArg(enLight.Green , GreenTime));
        }

           public event EventHandler<TrafficLightEventArg> OrangeLightOff; 

        public void RaiseOrangeLightOff()
        {
            RedLightOff?.Invoke(this, new TrafficLightEventArg(enLight.Oragne, OrangeTime));
        }


        int _RedTime = 10; 
        int _GreenTime = 10; 
        int _OrangeTime = 10;
        int _CurrentCountDownValue; 
        public int RedTime
        {
            get { return _RedTime; }
            set
            {
                _RedTime = value;
            }
        }
        
        public int GreenTime
        {
            get { return _GreenTime; }
            set
            {
                _GreenTime = value;
            }
        }
        
        public int OrangeTime
        {
            get { return _OrangeTime; }
            set
            {
                _OrangeTime = value;
            }
        }

        public int GetCurrentTime()
        {
            switch (_CurrentLight) { 
               case enLight.Green:
               return GreenTime;
            case enLight.Red:
               return RedTime;
            case enLight.Oragne:
               return OrangeTime;
                default:
                    return RedTime;  

            }
            }
     
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }


        public enLight CurrentLight
        {
            get
            {

                return _CurrentLight;
            }
set
            {
                _CurrentLight = value;

                switch (_CurrentLight)
                {
                    case enLight.Green:
                        pbTraffic.Image = Resources.Green;
                        lblTraffic.ForeColor = Color.Green;
                        break;
                    case enLight.Red:
                        pbTraffic.Image = Resources.Red;
                        lblTraffic.ForeColor = Color.Red;
                        break;
                    case enLight.Oragne:
                        pbTraffic.Image = Resources.Orange;
                        lblTraffic.ForeColor = Color.Orange;
                        break;
                    default:
                        break;
                }

            }





        }




        //public void ChangeLight(enLight Light)
        //{
        //    switch (Light)
        //    {
        //        case enLight.Green:
        //            pbTraffic.Image = Resources.Green;
        //            lblTraffic.Text = "Green";
        //            break;
        //   case enLight.Red:
        //            pbTraffic.Image = Resources.Red;
        //            lblTraffic.Text = "Red";
        //            break;
        //   case enLight.Oragne:
        //            pbTraffic.Image = Resources.Orange;
        //            lblTraffic.Text = "Orange";
        //            break;
        //        default:
        //            break; 
        //    }

        //}

        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            timer1.Start(); 
        }



        private void ctrlTrafficLight_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTraffic.Text = _CurrentCountDownValue.ToString(); 
            if(_CurrentCountDownValue==0)
            {
                _ChangeLight();
            }

            else
            {
                -- _CurrentCountDownValue;
            }
        }


        private enLight _LightAfterOrangeRedOrGreen; 


        void _ChangeLight()
        {
            switch (_CurrentLight)
            {
                case enLight.Red:
                    _LightAfterOrangeRedOrGreen = enLight.Green;
                    CurrentLight = enLight.Oragne;
                    _CurrentCountDownValue = OrangeTime;
                    lblTraffic.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;

                case enLight.Oragne: 
                    if(_LightAfterOrangeRedOrGreen==enLight.Green)
                    {
                        CurrentLight = enLight.Green;
                        _CurrentCountDownValue = GreenTime;
                        lblTraffic.Text = _CurrentCountDownValue.ToString();
                        RaiseGreenLightOn();
                    }
                    else
                    {
                        CurrentLight = enLight.Red;
                        _CurrentCountDownValue = RedTime;
                        lblTraffic.Text = _CurrentCountDownValue.ToString();
                        RaiseRedLightOn();
                    }

                    break;

                case enLight.Green  :
                    _LightAfterOrangeRedOrGreen = enLight.Red;

                    CurrentLight = enLight.Oragne;
                    _CurrentCountDownValue = OrangeTime;
                    lblTraffic.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;

                default:
                    pbTraffic.Image = Resources.Red;
                    break;



            }

        }
    }
}
