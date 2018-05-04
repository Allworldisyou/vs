using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myKTV
{
    class PlayList
    {
       

 //定义一个长度为、 的歌曲数组，默认存储 首歌曲
 public static Song[] SongList = new Song[50];
 public static int SongIndex;//当前播放的歌曲在数组中的索引
 //点播一首歌曲，其实是将歌曲对象添加到歌曲数组中
 public static bool AddSong(Song song)
 {
 bool success = false;//记录添加歌曲是否成功
 for (int i =0 ; i < SongList.Length; i++)
 {
  //找到数组中第一个为null的位置
  if (SongList[i] == null)
  {
  SongList[i] = song;
  success = true;
  break;
  }
 }
 return success;
 }
 //获取当前播放的歌曲：：既然是获取当前播放的歌曲，返回值肯定是Song类型
 public static Song GetPlaySong()
 {
 if (SongList[SongIndex] != null)
 {
  return SongList[SongIndex];
 }
 else
 {
  return null;
 }
 }
 /// <summary>
 /// 播放下一首
 /// </summary>
 public static void MoveOn()
 {
 if (SongList[SongIndex] != null && SongList[SongIndex].playState == SongPlayState.again)
 {
  SongList[SongIndex].SetSongPlayed();
 }
 else
 {
  SongIndex++;
 }
 }
 /// <summary>
 /// 当前播放的歌曲名称
 /// </summary>
 /// <returns>歌曲名称</returns>
 public static string PlayingSongName()
 {
 string songName = ""; // 歌曲名称
 if (SongList[SongIndex] != null)
 {
  songName = SongList[SongIndex].SongName;
 }
  return songName;
 }
 /// <summary>
 /// 下一首要播放的歌曲名称
 /// </summary>
 /// <returns>歌曲名称</returns>
 public static string NextSongName()
 {
 string songName = ""; // 歌曲名称
 if (SongList[SongIndex +1 ] != null)
 {
  songName = SongList[SongIndex + 1].SongName;
 }
  return songName;
 }
 //重放当前歌曲
 public static void PlayAgain()
 {
 if (SongList[SongIndex] != null)
 {
  SongList[SongIndex].SetPlayAgain();
 }
 }

         //切歌
 public static void CutSong()
 {
     //获取到当前播放的歌曲改变播放状态
     if (SongList[SongIndex] != null)
     {
         SongList[SongIndex].playState = SongPlayState.cut;
         ChargeInde();   //改变歌曲索引,播放下一首
     }
 }
  public static void ChargeInde()
        {
            SongIndex++;
        }



 //切歌
 public static void CutSong(int index)
 {
 int i;//循环变量，代表切歌的位置
 if (index == SongIndex)//循环变量，代表切割的位置
 {
  i = SongIndex;
 }
 else
 {
  i = index;//从切歌的位置开始，将歌曲逐个向前移一个位置
 }
 SongList[i].SetSongCut();
 while (SongList[i] != null)
 {
  SongList[i] = SongList[i+1];
  i++; 
  //如果达到数组最后一个元素，就将最后一个元素指向空
  if (i == SongList.Length)
  {
  SongList[i] = null;
  }
 }
 }



 

        }



    
}
