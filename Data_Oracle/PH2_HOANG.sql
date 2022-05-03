
CREATE ROLE ROLE_DOCTOR IDENTIFIED BY ROLE_DOCTOR;
GRANT CREATE SESSION TO ROLE_DOCTOR;
GRANT SELECT ON HSBA_DV TO ROLE_DOCTOR;
GRANT SELECT ON CTDONTHUOC TO ROLE_DOCTOR;
GRANT SELECT ON DICHVU TO ROLE_DOCTOR;
GRANT SELECT ON CSYT TO ROLE_DOCTOR;
GRANT INSERT(ketLuanCuaBacSi), UPDATE(ketLuanCuaBacSi)ON BENHNHAN TO ROLE_DOCTOR;
GRANT INSERT (maKB,maDV,ngayGio), UPDATE (maKB,maDV,ngayGio) ON DICHVU TO ROLE_DOCTOR;
GRANT INSERT, UPDATE (ketLuanCuaBacSi) ON BENHNHAN TO ROLE_DOCTOR;
GRANT INSERT, UPDATE (maKB,maDV,ngayGio) ON DICHVU TO ROLE_DOCTOR;

CREATE OR REPLACE FUNCTION FUNC_VPD_POLICY_DOCTOR_HOSOBENHNHAN(
    v_schema IN VARCHAR2,
    v_object IN VARCHAR2
)
RETURN VARCHAR2 
AS
    predicate VARCHAR2(200);
    cur_user VARCHAR2(200);
BEGIN

    cur_user:= SYS_CONTEXT('USERENV','SESSION_USER');
    IF (INSTR(cur_user,'BACSI')<>0) THEN
      predicate:= 'TENBACSI = ''' ||cur_user||'''';
    ELSE
     predicate:= '';
    END IF;
    RETURN predicate;
END FUNC_VPD_POLICY_DOCTOR_HOSOBENHNHAN;
/


alter session set "_ORACLE_SCRIPT"=true; 
CREATE ROLE role_dep_nghiencuu IDENTIFIED BY role_dep_nghiencuu;
--Grant policy
GRANT SELECT ON BENHNHAN TO role_dep_nghiencuu;
GRANT SELECT ON csyt TO role_dep_nghiencuu;
GRANT SELECT ON BENHNHAN TO role_dep_nghiencuu;
GRANT SELECT ON DICHVU TO role_dep_nghiencuu;
--Grant role to user
GRANT role_dep_nghiencuu TO user_nghiencuu_01;
GRANT role_dep_nghiencuu TO user_nghiencuu_02;
GRANT role_dep_nghiencuu TO user_nghiencuu_03;

CREATE OR REPLACE FUNCTION FUNC_VPD_POLICY_NGHIENCUU(
    v_schema IN VARCHAR2,
    v_object IN VARCHAR2
)
RETURN VARCHAR2 
AS
    predicate VARCHAR2(200);
    cur_user VARCHAR2(200);
BEGIN

    cur_user:= SYS_CONTEXT('USERENV','SESSION_USER');
    IF (INSTR(cur_user,'BACSI')<>0) THEN
      predicate:= 'TENBACSI = ''' ||cur_user||'''';
    ELSE
     predicate:= '';
    END IF;
    RETURN predicate;
END FUNC_VPD_POLICY_DOCTOR_NGHIENCUU;
/