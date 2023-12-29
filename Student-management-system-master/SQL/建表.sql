CREATE TABLE Student (
  Sno     VARCHAR(20)       PRIMARY KEY,
  Sname   VARCHAR(20)     NOT NULL,
  Class    VARCHAR(20), 
  Birthday  VARCHAR(20), 
  Place  VARCHAR(10),
  Spassword INT,
)

CREATE TABLE Course (
  Cno       VARCHAR(20)   PRIMARY KEY,
  Cname     VARCHAR(20)  NOT NULL,
  Credit    INT,
  Instructor  VARCHAR(6)
)

CREATE TABLE Teacher (
  TID    VARCHAR(20)   PRIMARY KEY,
  TName   VARCHAR(20)  NOT NULL,
  TPassword  INT,
  Title  VARCHAR(20),
  Tplace  VARCHAR(10)
)  
CREATE TABLE SC (
  Sno    VARCHAR(20)  NOT NULL,
  Cno    VARCHAR(20)  NOT NULL,
  PRIMARY KEY (Sno, Cno),
  FOREIGN KEY (Sno)  REFERENCES  Student (Sno),
  FOREIGN KEY (Cno)  REFERENCES  Course (Cno)  
)  

insert into Student values('0811102','����','�ƿ�1��','1999-1-5','����','23789')
insert into Student values('0811103','����','�ƿ�1��','2000-3-6','�ӱ�','67349')
insert into Student values('0811104','��С��','��ý1��','2000-7-7','����','76598')
insert into Student values('0821101','����','���2��','1999-2-10','����','66789')
insert into Student values('0821102','���','�ƿ�2��','1999-8-19','�㽭','33609')
insert into Student values('0831101','ǮСƽ','��3��','2000-8-20','����','25780')
insert into Student values('0831102','����','�ƿ�2��','1998-3-6','����','09745')
insert into Student values('0831103','�ź�','��2��','1998-9-28','����','67389')
insert into Student values('0841101','������','�ƿ�3��','2001-2-19','�Ĵ�','10776')
insert into Student values('0841102','����','�ƿ�3��','2000-8-9','����','66879')
insert into Student values('0841103','����','��ý1��','1999-1-18','����','55765')

insert into Course values('C001','�ߵ���ѧ',4,'��ɺɺ')
insert into Course values('C002','��ѧӢ��',3,'�ź�')
insert into Course values('C003','���ݿ����',3,'��ΰ')
insert into Course values('C004','���ݽṹ',4,'����')
insert into Course values('C005','������Ļ�',4,'������')
insert into Course values('C006','���Դ���',3,'�ֻ�')
insert into Course values('C007','Python',3,'�ַ�')
insert into Course values('C008','VB',4,'Ҷ��')
insert into Course values('C009','���������',3,'��ɺ��')


insert into Teacher values('001','��ɺɺ','21106','����','�Ĵ�')
insert into Teacher values('002','�ź�','35674','����','�㽭')
insert into Teacher values('003','��ΰ','43358','������','����')
insert into Teacher values('004','����','22267','������','ɽ��')
insert into Teacher values('005','����ɽ','59246','����','����')
insert into Teacher values('006','������','12345','����','����')
insert into Teacher values('007','�ֻ�','23567','����','����')
insert into Teacher values('008','�ַ�','45798','������','�㽭')
insert into Teacher values('009','Ҷ��','44569','������','����')
insert into Teacher values('010','��ɺ��','67904','����','����')

insert into SC values('0811102','C001')
insert into SC values('0811102','C003')
insert into SC values('0811103','C003')
insert into SC values('0811104','C004')
insert into SC values('0821101','C002')
insert into SC values('0821102','C003')
insert into SC values('0831101','C003')
insert into SC values('0831102','C007')
insert into SC values('0831102','C003')
insert into SC values('0841101','C005')
insert into SC values('0841102','C006')
