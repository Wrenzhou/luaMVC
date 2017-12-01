
namespace Game
{
	public partial class NotificationType
	{
		// OPERATE ������
		public const string CLICK = "MouseClick";

		// TOHUD ��ͼ��Ϣ����
		public const string UPDATESCORE = "UpdateScore";
		public const string UPDATETIMESLIDER = "UpdateTimeSlider";
        
        // TIME ʱ��
	    public const string TIME_TIMEIN = "TimeIn";
	    public const string TIME_TIMEUP = "TimeUp";
	    public const string TIME_ADDUPPERLIMIT = "AddUpperLimit";
	    public const string TIME_ADDTIME = "AddTime";
	    public const string TIME_REDUCETIME = "ReduceTime";
	    public const string TIME_REMAIN = "RemainTime";
	    public const string TIME_TIMEWARNING = "TimeWarning";

        // MODEL TO VIEW
	    public const string M2V_PLAYERINFO_UPDATE = "UpdatePlayerInfo";
	    public const string M2V_PLAYERINFO_UPDATEFAIL = "UpdatePlayerInfoFailed";

        // VIEW TO VIEW
	    public const string V2V_GAME_START = "GameStart";
	    public const string V2V_GAME_ACCOUNT = "GameAccount";

	    public const string V2V_GAME_REGISTER = "Register";


        // todo COMMAND 
        public const string COMMAND_ACCOUNT = "Account";
	}
}