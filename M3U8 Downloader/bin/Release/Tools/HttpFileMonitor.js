// �밴��ʽ�޸�,�޸Ĵ����޷���������
// ������ڱ��ļ���������µ����ع��߻��������˴��󣬿��԰��µĸ���ͨ���ʼ�(AKenSoft-Service@Yahoo.com.cn)���͸���

function GetIncludeFilters(){
	return "*.m3u8;*.flv;decode.php;proxy.php";
}

function GetExcludeFilters(){
	return "";
}

function GetDownloadNames(){
	// �������޸����ع�������
	return "��Ѹ��������ѡ|�����ʿ쳵������ѡ|��Ӱ�����ʹ�������ѡ|����������������ѡ";
}

function DownFile(DownloadName,Url,Info,Location,strCookie){
	//Url=���ص�ַ	Info=��Ϣ		Location=���õ�ַ			strCookie=Cookie
	var rMsg="";
	try{
		// �������������޸����ع���
		if(DownloadName=="��Ѹ��������ѡ"){//Ѹ�ײ��Թ���һ������������֧��COOKIE
			rMsg="Ѹ��";
			var AgentObj=new ActiveXObject('ThunderAgent.Agent');
			AgentObj.AddTask5(Url, '', '', Info, Location, -1, 0, -1, strCookie, '', '', 1, '', -1);
			AgentObj.CommitTasks2(1);
		}else if(DownloadName=="�����ʿ쳵������ѡ"){//���ʿ쳵û�в��Թ������ڲ�֧��COOKIE
			rMsg="���ʿ쳵";
			var AgentObj=new ActiveXObject('JetCar.Netscape');
			AgentObj.AddUrl(Url, Info, Location);
		}else if(DownloadName=="��Ӱ�����ʹ�������ѡ"){//Ӱ�����ʹ�û�в��Թ������ڲ�֧��COOKIE
			rMsg="Ӱ�����ʹ�";
			var AgentObj=new ActiveXObject('NTIEHelper.NTIEAddUrl');
			AgentObj.AddUrl(Location, Url, Info);
		}else if(DownloadName=="����������������ѡ"){//��������û�в��Թ������ڲ�֧��COOKIE
			rMsg="��������";
			var AgentObj=new ActiveXObject('NetAnts.API');
			AgentObj.AddUrl(Url, Info, Location);
		}else{
			return "û���ҵ����ع���!";
		}
	}catch(e){return "����û�а�װ"+rMsg+"!";}
}

/*
	ThunderAgent.Agent			Ѹ��
	JetCar.Netscape			���ʿ쳵
	NTIEHelper.NTIEAddUrl		Ӱ�����ʹ�
	NetAnts.API				��������
*/
