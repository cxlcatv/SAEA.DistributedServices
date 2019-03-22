﻿/****************************************************************************
*项目名称：SAEA.DSModel
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：SAEA.DSModel
*类 名 称：Transaction
*版 本 号：V1.0.0.0
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/3/21 14:38:55
*描述：
*=====================================================================
*修改时间：2019/3/21 14:38:55
*修 改 人： yswenli
*版 本 号： V1.0.0.0
*描    述：
*****************************************************************************/
using System;

namespace SAEA.DSModel
{
    public class Transaction
    {
        public string ID
        {
            get;set;
        }
        public TransactionStatus TransactionStatus
        {
            get; set;
        } = TransactionStatus.None;

        public DateTime Created
        {
            get; set;
        } = DateTime.Now;
    }
}
