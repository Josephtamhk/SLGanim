﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    #region 游戏参数
    public static string version = "0.2";
    #endregion

    #region 游戏数据
    public static int playerNumber = 1;
    public static CharacterDataBase characterDB;
    public static List<CharacterData> characterList = new List<CharacterData>();
    public static List<ItemData> items = new List<ItemData>();
    #endregion

    #region 存档数据
    public static string createVersion;
    public static string createDate;
    public static string saveVersion;
    public static string saveDate;
    public static DataRegister playerData = new DataRegister();
    #endregion

}
