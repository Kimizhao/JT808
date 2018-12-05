﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Extensions.DependencyInjection.Options
{
    public class JT808Options
    {
        public JT808Options()
        {
            SkipCRCCode = false;
            JT808LocationAttachMethod = new Dictionary<byte, Type>();
            JT808_0x0900Method = new Dictionary<byte, Type>();
            JT808_0x8900Method = new Dictionary<byte, Type>();
        }

        /// <summary>
        /// 设置跳过校验码
        /// 场景：测试的时候，可能需要收到改数据，所以测试的时候有用
        /// </summary>
        public bool SkipCRCCode { get; set; }
        /// <summary>
        /// 注册自定义定位信息附加数据
        /// <see cref="typeof(JT808.Protocol.MessageBody.JT808LocationAttach.JT808LocationAttachBase)"/>
        /// <see cref="typeof(实现JT808LocationAttachBase)"/>
        /// </summary>
        public Dictionary<byte, Type> JT808LocationAttachMethod { get; set; }
        /// <summary>
        /// 注册自定义数据上行透传信息
        /// <see cref="typeof(JT808.Protocol.MessageBody.JT808_0x8900_0x0900_Body.JT808_0x0900_BodyBase)"/>
        /// <see cref="typeof(实现JT808_0x0900_BodyBase)"/>
        /// </summary>
        public Dictionary<byte, Type> JT808_0x0900Method { get; set; }
        /// <summary>
        /// 注册自定义数据下行透传信息
        /// <see cref="typeof(JT808.Protocol.MessageBody.JT808_0x8900_0x0900_Body.JT808_0x8900_BodyBase)"/>
        /// <see cref="typeof(实现JT808_0x8900_BodyBase)"/>
        /// </summary>
        public Dictionary<byte, Type> JT808_0x8900Method { get; set; }


    }
}