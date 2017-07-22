using System;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Modbus_RTU_test
{
    public class ModbusClient
    {

        //ModbusClient与PLC通信，此client是读写数字量
        //读 需要先给modbusClient发送消息，消息包括: 设备地址 设备站点 数据地址 ,plc返回数据是有crc校验的数据
        // 写 根据plc给的地址直接写入数据。需要校验


        public int[,] AnalogArr;
        public int[,] SwitchArr;
        private ArrayList SendArray = new ArrayList();
        private SerialPort SPort = new SerialPort();
        public bool IsOpen = false;
        public string PortName = "";
        public int PortAddr = 1;
        public bool PortFlag = false;
        public int RcvTime = 0;
        //        public bool isRead = false;

        public event Action<string> ReceivedData;

        public ModbusClient()
        { }
        public ModbusClient(int analogNum, int switchNum)
        {
            AnalogArr = new int[256, analogNum];
            SwitchArr = new int[256, switchNum];
        }

        //打开串口
        public bool Open(string portName, int baudRate, int databits, Parity parity, StopBits stopBits, int readTimeout, int writeTimeout)
        {
            try
            {
                if (!SPort.IsOpen)
                {
                    PortName = portName;
                    SPort.PortName = portName;
                    SPort.BaudRate = baudRate;
                    SPort.DataBits = databits;
                    SPort.Parity = parity;
                    SPort.StopBits = stopBits;
                    SPort.ReadTimeout = readTimeout;
                    SPort.WriteTimeout = writeTimeout;
                    SPort.DataReceived += SPort_DataReceived;
                    SPort.Open();
                }
                IsOpen = true;
                return true;
            }
            catch
            {
                MessageBox.Show("打开连接出错");
                return false;
            }
        }

        void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            CommonTools.Delay(500);
            if (!IsOpen)
            {
                return;
            }
            if (SPort.BytesToRead > 0 )
            {
                byte[] dataBytes = new byte[SPort.BytesToRead];
                SPort.Read(dataBytes, 0, SPort.BytesToRead);

                //SPort.DiscardInBuffer();
                //SPort.DiscardOutBuffer();

                //               string strDebug = CommonTools.ToHexString(dataBytes); //调试用
                if (CheckResponse(dataBytes, dataBytes.Length))
                {
                    ReceivedData(CommonTools.ToHexString(dataBytes));
                }
                else
                {
                    ReceivedData("CRC_Error");
                }
            }


        }

        //关闭串口
        public bool Close()
        {
            try
            {
                if (SPort.IsOpen)
                    SPort.Close();
                IsOpen = false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        #region 检查CRC校验
        private bool CheckResponse(byte[] response, int Length)
        {
            byte[] CRC = new byte[2];
            GetCRC(response, Length, ref CRC);
            try
            {
                if (CRC[0] == response[Length - 2] && CRC[1] == response[Length - 1])
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 计算CRC
        private void GetCRC(byte[] message, int Length, ref byte[] CRC)
        {
            ushort CRCFull = 0xFFFF;
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;

            for (int i = 0; i < Length - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        }
        #endregion

        #region 作废
        /// <summary>
        /// 给PLC发送模拟量消息
        /// </summary>
        // public void SendPLC(int address , int start ,short[] value)
        // {
        //     //try
        //     //{
        //         byte[] message = new byte[16];
        //         message = AnalogWrite(address, start, value);                
        //         byte[] RBytes = new byte[100];
        //         int ReadLength=0;
        //         //int thislength = 0;
        //         SPort.Write(message, 0, message.Length);
        //         Thread.Sleep(1000);
        //         //do
        //         //{                    
        //         //    Thread.Sleep(2000);
        //         //    ReadLength = SPort.Read(RBytes, 0, SPort.BytesToRead);
        //         //    if (ReadLength == 0)
        //         //        continue;
        //         //}
        //         //while (!CheckResponse(RBytes, ReadLength));

        //         //RcvTime = 0;
        //         //PortFlag = true;                
        //     //}
        //     //catch (Exception ex)
        //     //{             
        //     //    throw;
        //     //}      

        // }
        #endregion


        #region 不用
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="bytes"></param>
        ///// <param name="address"></param>
        ///// <param name="thislength"></param>
        //public void PD(byte[] bytes, int address, int thislength)
        //{
        //    //根据功能码判断类型
        //    //开关量读取返回
        //    if (bytes[1] == (byte)0x1 || bytes[1] == (byte)0x2 || bytes[1] == 0x6)
        //    {
        //        try
        //        {
        //            byte[] by = new byte[bytes[2]];
        //            for (int i = 0; i < bytes[2]; i++)
        //            {
        //                by[i] = bytes[3 + i];
        //                string alarmArr = Convert.ToString(by[i], 2).PadLeft(8, '0');
        //                for (int j = 7; j >= 0 && 7 - j + i * 8 < thislength; j--)
        //                {
        //                    SwitchArr[bytes[0], address + i * 8 + (7 - j)] = (alarmArr[j] == '1' ? 1 : 0);
        //                }
        //            }
        //        }
        //        catch { }
        //    }
        //    //开关量写入返回
        //    else if (bytes[1] == (byte)0xF)
        //    {

        //    }
        //    //模拟量读取返回
        //    else if (bytes[1] == (byte)3 || bytes[1] == (byte)4)
        //    {
        //        try
        //        {
        //            int Num = bytes[2] / 2;
        //            for (int i = 0; i < bytes[2]; )
        //            {
        //                AnalogArr[bytes[0], address++] = (bytes[3 + (i++)] << 8) + bytes[3 + (i++)];
        //            }
        //        }
        //        catch { }
        //    }
        //    //模拟量写入返回
        //} 
        #endregion

        //开关量写方法
        public byte[] SwitchWrite(int address, int start, short[] Values)
        {
            int byteNum = ((Values.Length % 8 == 0) ? Values.Length / 8 : Values.Length / 8 + 1);
            byte[] message = new byte[9 + byteNum];
            message[0] = (byte)address;
            message[1] = (byte)0xF;//写多线圈功能码
            message[2] = (byte)((start - 1) >> 8);//Modbus的地址小一
            message[3] = (byte)((start - 1) & 0xFF);
            message[4] = (byte)(Values.Length >> 8);
            message[5] = (byte)(Values.Length & 0xFF);
            message[6] = (byte)byteNum;
            for (int i = 0; i < byteNum; i++)
            {
                int ABC = 0;
                for (int j = i * 8; j < Values.Length && j < (i + 1) * 8; j++)
                {
                    if (Values[j] > 0)
                        ABC = ABC + (int)System.Math.Pow(2, (j - i * 8));
                }
                message[7 + i] = (byte)ABC;
            }
            byte[] CRC = new byte[2];
            GetCRC(message, message.Length, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
            SPort.Write(message, 0, message.Length);
            return message;
        }

        /// <summary>
        /// 01-04读请求帧方法
        /// </summary>
        /// <param name="funcCode"></param>
        /// <param name="address"></param>
        /// <param name="start"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        public byte[] GetFromPLC(byte funcCode, int address, int start, int Count)
        {
            SPort.DiscardInBuffer();
            SPort.DiscardOutBuffer();

            byte[] message = new byte[8];
            message[0] = (byte)address;
            message[1] = funcCode;//读功能码
            //message[2] = (byte)((start - 1) >> 8);//Modbus的地址小一
            //message[3] = (byte)((start - 1) & 0xFF);
            message[2] = (byte)(start >> 8);//Modbus的地址小一
            message[3] = (byte)(start  & 0xFF);
            message[4] = (byte)(Count >> 8);
            message[5] = (byte)(Count & 0xFF);
            byte[] CRC = new byte[2];
            GetCRC(message, message.Length, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
            SPort.Write(message, 0, message.Length);
            return message;
        }

        /// <summary>
        /// 读V区请求帧方法
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="start">1</param>
        /// <param name="Count">40</param>
        /// <returns></returns>
        public byte[] GetVBytes(int address, int start, int Count)
        {

            SPort.DiscardInBuffer();
            SPort.DiscardOutBuffer();

            byte[] message = new byte[8];
            message[0] = (byte)address;
            message[1] = (byte)0x3;//读线圈功能码
            message[2] = (byte)((start - 1) >> 8);//Modbus的地址小一
            message[3] = (byte)((start - 1) & 0xFF);
            message[4] = (byte)(Count >> 8);
            message[5] = (byte)(Count & 0xFF);
            byte[] CRC = new byte[2];
            GetCRC(message, message.Length, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
            SPort.Write(message, 0, message.Length);
            return message;
        }

        public byte[] GetQbytes(int address, int start, int Count)
        {
            byte[] message = new byte[8];
            message[0] = (byte)address;
            message[1] = (byte)0x1;//读线圈功能码
            message[2] = (byte)((start - 1) >> 8);//Modbus的地址小一
            message[3] = (byte)((start - 1) & 0xFF);
            message[4] = (byte)(Count >> 8);
            message[5] = (byte)(Count & 0xFF);
            byte[] CRC = new byte[2];
            GetCRC(message, message.Length, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
            SPort.Write(message, 0, message.Length);
            return message;
        }

        ////模拟量写方法
        //public byte[] AnalogWrite(int address, int start, short[] values)
        //{
        //    int Count = values.Length;
        //    byte[] message = new byte[9 + 2 * Count];
        //    byte[] CRC = new byte[2];

        //    message[0] = (byte)address;
        //    message[1] = (byte)0x10;//写多寄存器
        //    message[2] = (byte)((start - 1) >> 8);//Modbus的地址小一
        //    message[3] = (byte)((start - 1) & 0xFF);
        //    message[4] = (byte)(Count >> 8);
        //    message[5] = (byte)(Count & 0xFF);
        //    message[6] = (byte)(Count * 2);
        //    for (int i = 0; i < Count; i++)
        //    {
        //        message[7 + 2 * i] = (byte)(values[i] >> 8);
        //        message[8 + 2 * i] = (byte)(values[i]);
        //    }
        //    GetCRC(message, message.Length, ref CRC);
        //    message[message.Length - 2] = CRC[0];
        //    message[message.Length - 1] = CRC[1];
        //    return message;
        //}

        public byte[] WriteVByte(int address, int start, short value)
        {
            byte[] message = new byte[8];
            byte[] CRC = new byte[2];

            message[0] = (byte)address;
            message[1] = (byte)0x6;//写存器
            //message[2] = (byte)((start - 1) >> 8);//Modbus的地址小一
            //message[3] = (byte)((start - 1) & 0xFF);
            message[2] = (byte)(start >> 8);//Modbus的地址小一
            message[3] = (byte)(start & 0xFF);
            message[4] = (byte)(value >> 8);
            message[5] = (byte)(value & 0xFF);
            GetCRC(message, message.Length, ref CRC);
            message[message.Length - 2] = CRC[0];
            message[message.Length - 1] = CRC[1];
            SPort.Write(message, 0, message.Length);
            return message;
        }

    }
}
