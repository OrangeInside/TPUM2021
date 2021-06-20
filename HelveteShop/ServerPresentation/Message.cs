﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ServerPresentation
{
    public class Message
    {
        public string Command { get; set; }
        public object Data { get; set; }
        public string DataType { get; set; }
    }

    public static class MessageParser
    {
        public static string Create(string command, object data, string dataType)
        {
            Message msg = new Message() { Command = command, Data = data, DataType = dataType };
            return JsonSerializer.Serialize(msg);
        }

        public static Message Deserialize(string message)
        {
            return JsonSerializer.Deserialize<Message>(message);
        }

        public static T DeserializeType<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
