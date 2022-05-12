SET SQLBLANKLINES ON;
SET DEFINE OFF;
ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY/MM/DD';
ALTER SESSION SET NLS_TIMESTAMP_TZ_FORMAT = 'YYYY/MM/DD';
ALTER SESSION SET NLS_TIMESTAMP_FORMAT = 'YYYY/MM/DD';
ALTER SESSION SET NLS_NUMERIC_CHARACTERS = '.,';
ALTER SESSION SET NLS_NCHAR_CONV_EXCP = FALSE;
ALTER SESSION SET TIME_ZONE = '+07:00';
--------------------- TAO USER -------------------------
create or replace procedure createUser_nhanvien
IS    
    li_count INTEGER :=0;
    lv_stmt VARCHAR2(1000);
BEGIN
    FOR loop_counter IN 1..605
    LOOP
        lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE ';
        EXECUTE IMMEDIATE (lv_stmt);

        lv_stmt:='CREATE USER ' || 'NV' || loop_counter || ' IDENTIFIED BY ' || '123456';
        EXECUTE IMMEDIATE (lv_stmt);
    
        lv_stmt:='GRANT CONNECT TO ' || 'NV' || loop_counter;
        EXECUTE IMMEDIATE (lv_stmt);

        lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE ';
        EXECUTE IMMEDIATE (lv_stmt);
    END LOOP;
COMMIT;
END createUser_nhanvien;

--exec createuser_nhanvien();
/
create or replace procedure createUser_benhnhan 
IS    
    li_count INTEGER :=0;
    lv_stmt VARCHAR2(1000);
BEGIN
    FOR loop_counter IN 1..10000
    LOOP
        lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE ';
        EXECUTE IMMEDIATE (lv_stmt);

        lv_stmt:='CREATE USER ' || 'BN' || loop_counter || ' IDENTIFIED BY ' || '123456';
        EXECUTE IMMEDIATE (lv_stmt);
    
        lv_stmt:='GRANT CONNECT TO ' || 'BN' || loop_counter;
        EXECUTE IMMEDIATE (lv_stmt);

        lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE ';
        EXECUTE IMMEDIATE (lv_stmt);
    END LOOP;
COMMIT;
END createUser_benhnhan;
/
--exec createuser_benhnhan();

-- Tao 1 tai khoan cho nguoi dung nhan vien hoac benh nhan:
CREATE OR REPLACE PROCEDURE createUser(
    pi_username IN NVARCHAR2,
    pi_password IN NVARCHAR2)
IS    
    user_name  NVARCHAR2(20):= pi_username;
    pwd NVARCHAR2(20):= pi_password;
    li_count INTEGER :=0;
    lv_stmt VARCHAR(1000);
    BEGIN
    SELECT COUNT (1)
    INTO li_count
    FROM all_users
    WHERE username =UPPER(user_name);
    IF li_count !=0
    THEN 
        lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE ';
        EXECUTE IMMEDIATE (lv_stmt);
        
        lv_stmt:='DROP USER ' ||user_name ||' CASCADE';
        EXECUTE IMMEDIATE (lv_stmt);
        
        lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE ';
        EXECUTE IMMEDIATE (lv_stmt);
    END IF;
    
    lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE ';
    EXECUTE IMMEDIATE (lv_stmt);
    
    lv_stmt:='CREATE USER ' || user_name|| ' IDENTIFIED BY ' || pwd;
    EXECUTE IMMEDIATE (lv_stmt);
    
    lv_stmt:='GRANT CONNECT TO ' ||user_name;
    EXECUTE IMMEDIATE (lv_stmt);
    
    lv_stmt:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE ';
    EXECUTE IMMEDIATE (lv_stmt);
    
    COMMIT;
END createUser;
/
CREATE OR REPLACE PROCEDURE deleteUser(
    ip_username IN NVARCHAR2)
IS
user_name NVARCHAR2(20):=ip_username;
exec_commander VARCHAR(1000);
    BEGIN
        exec_commander := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE ';
        EXECUTE IMMEDIATE (exec_commander);
        
        exec_commander :='DROP USER ' || user_name|| ' CASCADE ';
        EXECUTE IMMEDIATE (exec_commander);
        
        exec_commander := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE ';
        EXECUTE IMMEDIATE (exec_commander);
        
        COMMIT;    
END deleteUser;
/
-- Store procedure Gan Role cho User
create or replace procedure GanRole_Nhanvien(begin_number in number, end_number in number, role_name in varchar2)
is
exec_commander varchar(1000);
begin
    FOR loop_counter IN begin_number..end_number
    LOOP
        exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
        EXECUTE IMMEDIATE(exec_commander);

        exec_commander:='GRANT ' || role_name || ' TO ' || 'NV' || loop_counter;
        EXECUTE IMMEDIATE(exec_commander);
        
        exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
        EXECUTE IMMEDIATE(exec_commander);
     END LOOP;   
commit;
end;
/

create or replace procedure GanRole_BENHNHAN(begin_number in number, end_number in number, role_name in varchar2)
is
exec_commander varchar(1000);
begin
    FOR loop_counter IN begin_number..end_number
    LOOP
        exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
        EXECUTE IMMEDIATE(exec_commander);

        exec_commander:='GRANT ' || role_name || ' TO ' || 'BN' || loop_counter;
        EXECUTE IMMEDIATE(exec_commander);
        
        exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
        EXECUTE IMMEDIATE(exec_commander);
     END LOOP;   
commit;
end;
/
create or replace procedure GanRole_user(user_name in varchar2, role_name in varchar2)
is
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='GRANT ' || role_name || ' TO ' || user_name;
    EXECUTE IMMEDIATE(exec_commander);
        
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander); 
commit;
end;
/
-- Cac function va store procedure ho tro chuc nang
CREATE OR REPLACE FUNCTION take_sysday
return number
is
out_day number(2) := 0;
begin
     SELECT TO_NUMBER(TO_CHAR
    (SYSDATE, 'DD'),'99') into out_day
     FROM DUAL;
     return out_day;
end;
/
create or replace procedure insert_HSBA(
ip_mahsba in number, ip_mabn in number, ip_ngay in date, ip_chandoan in varchar2, ip_mabs in number, ip_makhoa in number, ip_macsyt in number, ip_ketqua in varchar2)
is
c number(2);
begin
    c:= take_sysday();
    if  c >= 5 and c <= 27 then
        INSERT INTO hethong.HSBA(MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) VALUES (ip_mahsba, ip_mabn, ip_ngay , ip_chandoan , ip_mabs , ip_makhoa , ip_macsyt ,ip_ketqua);
    END IF;
commit;
end;
/
create or replace procedure delete_HSBA(
ip_mahsba in number)
is
c number(2);
begin
    c:= take_sysday();
    if  c >= 5 and c <= 27 then
       DELETE FROM HSBA WHERE MAHSBA = ip_mahsba;
    else
     DBMS_OUTPUT.PUT_LINE('Khong the thuc hien thao tac o thoi diem hien tai!');
    END IF;
commit;
end;
/
create or replace procedure insert_HSBA_DV(
ip_mahsba in number, ip_madv in number, ip_ngay in date, ip_maktv in varchar2, ip_ketqua in varchar2)
is
c number(2);
begin
    c:= take_sysday();
    if  c >= 5 and c <= 27 then
        INSERT INTO hethong.HSBA_DV(MAHSBA, MADV, NGAY, MAKTV, KETQUA) VALUES (ip_mahsba, ip_madv, ip_ngay , ip_maktv, ip_ketqua);
    END IF;
commit;
end;
/
create or replace procedure delete_HSBA_DV(
ip_mahsba in number, ip_madv in number, ip_ngay in date)
is
c number(2);
begin
    c:= take_sysday();
    if  c >= 5 and c <= 27 then
       DELETE FROM HSBA_DV WHERE MAHSBA = ip_mahsba and MADV = ip_madv and NGAY = ip_ngay;
    END IF;
commit;
end;
/
create or replace function take_vaitro
return varchar2
as
ip_result varchar2(100);
begin
    select VAITRO into ip_result
    from NHANVIEN
    where MANV = substr(sys_context('userenv', 'session_user'), 3);
    return ip_result;
end;
/
---------- Tao role -----------------
ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE;
create role dba_role;

create role thanhtra_role;

create role nvcsyt_role;

create role ybacsi_role;

create role nghiencuu_role;

create role benhnhan_role;
ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;

----------- VPD Xem va sua thong tin ca nhan ------------

create or replace function id_nhanvien(
p_schema in varchar2 default null,
p_object in varchar2 default null)
return varchar2
as
begin
    if substr(sys_context('userenv', 'session_user'), 1, 2) = 'NV' then
        return 'MANV = ' || substr(sys_context('userenv', 'session_user'), 3);
    elsif sys_context('userenv', 'session_user') = 'HETHONG' then
        return '';
    elsif substr(sys_context('userenv', 'session_user'), 1, 3) = 'DBA' then
        return '';
    else
        return 'MANV = ' || 0;
    end if;
    commit;
end;
--begin
--DBMS_RLS.DROP_POLICY('hethong', 'NHANVIEN', 'Xem_cap_nhat_nhan_vien');
--end;
/
BEGIN DBMS_RLS.add_policy
(object_schema => 'hethong',
object_name => 'NHANVIEN',
policy_name => 'Xem_cap_nhat_nhan_vien',
function_schema => 'hethong',
policy_function => 'id_nhanvien',
statement_types => 'SELECT, UPDATE',
update_check => TRUE);
END;
/
BEGIN DBMS_RLS.add_policy
(object_schema => 'hethong',
object_name => 'NHANVIEN',
policy_name => 'Them_nhan_vien',
function_schema => 'hethong',
policy_function => 'id_nhanvien',
statement_types => 'INSERT',
update_check => TRUE);
END;
/
--begin
--DBMS_RLS.DROP_POLICY('hethong', 'NHANVIEN', 'Them_nhan_vien');
--end;
------ VPD Them xoa sua HSBA ---------------
create or replace function themxoa_hsba(
p_schema in varchar2 default null,
p_object in varchar2 default null)
return varchar2
as
ip_result1 number;
ip_result2 number;
ip_vaitro varchar2(100);
begin
    ip_vaitro := take_vaitro();
    if ip_vaitro = 'Co so y te' then
        select CSYT into ip_result1
        from NHANVIEN
        where MANV = substr(sys_context('userenv', 'session_user'), 3);
        return 'MACSYT = ' || ip_result1;
    elsif ip_vaitro = 'Thanh tra' then
        return '';
    elsif ip_vaitro = 'Bac si' or ip_vaitro = 'Y si' then
        return 'MABS = ' || substr(sys_context('userenv', 'session_user'), 3);
    elsif ip_vaitro = 'Nghien cuu' then
        select CSYT, CHUYENKHOA into ip_result1, ip_result2
        from NHANVIEN
        where MANV = substr(sys_context('userenv', 'session_user'), 3);
        return 'MACSYT = ' || ip_result1 || ' and ' || 'MAKHOA = ' || ip_result2;
    end if;
end;
/
BEGIN DBMS_RLS.add_policy
(object_schema => 'hethong',
object_name => 'HSBA',
policy_name => 'XemHSBA',
function_schema => 'hethong',
policy_function => 'themxoa_hsba',
statement_types => 'SELECT');
END;
/
--begin
--DBMS_RLS.DROP_POLICY('hethong', 'HSBA', 'XemHSBA');
--end;
--/
BEGIN DBMS_RLS.add_policy
(object_schema => 'hethong',
object_name => 'HSBA',
policy_name => 'them_xoa_HSBA',
function_schema => 'hethong',
policy_function => 'themxoa_hsba',
statement_types => 'INSERT, DELETE',
update_check => TRUE);
END;
/
--begin
--DBMS_RLS.DROP_POLICY('hethong', 'HSBA_DV', 'them_xoa_HSBA');
--end;
--/
------ VPD Them xoa sua HSBA_DV-----------

create or replace function themxoa_hsba_dv(
p_schema in varchar2 default null,
p_object in varchar2 default null)
return varchar2
as
ip_vaitro varchar2(100);
begin
    ip_vaitro := take_vaitro();
    if ip_vaitro = 'Thanh tra' then
        return '';
    else
        return 'MAHSBA in (select h.mahsba
        from HSBA h)';
    end if;
end;
/
BEGIN DBMS_RLS.add_policy
(object_schema => 'hethong',
object_name => 'HSBA_DV',
policy_name => 'XemHSBA_DV',
function_schema => 'hethong',
policy_function => 'themxoa_hsba_dv',
statement_types => 'SELECT');
END;
/
--begin
--DBMS_RLS.DROP_POLICY('hethong', 'HSBA_DV', 'XemHSBA_DV');
--end;
--/
BEGIN DBMS_RLS.add_policy
(object_schema => 'hethong',
object_name => 'HSBA_DV',
policy_name => 'them_xoa_HSBA_DV',
function_schema => 'hethong',
policy_function => 'themxoa_hsba_dv',
statement_types => 'INSERT, DELETE',
update_check => TRUE);
END;
/
--begin
--DBMS_RLS.DROP_POLICY('hethong', 'HSBA_DV', 'them_xoa_HSBA_DV');
--end;

---------- VPD xem thong tin benh nhan --------

create or replace function id_benhnhan(
p_schema in varchar2 default null,
p_object in varchar2 default null)
return varchar2
as
ip_vaitro varchar2(100);
begin
    ip_vaitro := take_vaitro();
    if substr(sys_context('userenv', 'session_user'), 1, 2) = 'BN' then
        return 'MABN = ' || substr(sys_context('userenv', 'session_user'), 3);
    elsif sys_context('userenv', 'session_user') = 'HETHONG' or ip_vaitro = 'Bac si' or ip_vaitro = 'Y si' or ip_vaitro = 'Thanh tra' then
        return '';
    end if;
    commit;
end;
/
BEGIN DBMS_RLS.add_policy
(object_schema => 'hethong',
object_name => 'BENHNHAN',
policy_name => 'Xem_cap_nhat_benh_nhan',
function_schema => 'hethong',
policy_function => 'id_benhnhan',
statement_types => 'SELECT, UPDATE',
update_check => TRUE);
END;
--begin
--DBMS_RLS.DROP_POLICY('hethong', 'BENHNHAN', 'Xem_cap_nhat_benh_nhan');
--end;

---------- Vai tro cua dba -----------

grant insert, update on CSYT to dba_role;

grant select, insert on NHANVIEN to dba_role;

grant execute on createUSER to dba_role;

exec createUser('DBA1','123456');
exec createUser('DBA2','123456');

---------- Vai tro cua Thanh tra ---------------

grant select on HSBA to thanhtra_role;
grant select on HSBA_DV to thanhtra_role;
grant select on CSYT to thanhtra_role;
grant select on BENHNHAN to thanhtra_role;
grant select on KHOA to thanhtra_role;
grant select on DICHVU to thanhtra_role;
grant select on NHANVIEN to thanhtra_role;
grant update on NHANVIEN to thanhtra_role;

----------- Vai tro cua Nhan vien quan ly ------

grant select, insert, delete on HSBA to nvcsyt_role;
grant select, insert, delete on HSBA_DV to nvcsyt_role;
grant select on NHANVIEN to nvcsyt_role;
grant update on NHANVIEN to nvcsyt_role;
grant execute on insert_HSBA to nvcsyt_role;
grant execute on delete_HSBA to nvcsyt_role;
grant execute on insert_HSBA_DV to nvcsyt_role;
grant execute on delete_HSBA_DV to nvcsyt_role;

----------- Vai tro cua Bac si / y si ----------

grant select on NHANVIEN to ybacsi_role;
grant update on NHANVIEN to ybacsi_role;
grant select on HSBA to ybacsi_role;
grant select on HSBA_DV to ybacsi_role;
grant select on BENHNHAN to ybacsi_role;

----------- Vai tro cua Nghien cuu ----------

grant select on NHANVIEN to nghiencuu_role;
grant update on NHANVIEN to nghiencuu_role;
grant select on HSBA to nghiencuu_role;
grant select on HSBA_DV to nghiencuu_role;

------------ Vai tro cua Benh nhan ----------

grant select on BENHNHAN to benhnhan_role;
grant update on BENHNHAN to benhnhan_role;

----- Gan role cho cac user -----------------

exec createUSER_NHANVIEN;
exec createUSER_benhnhan;
exec ganrole_user('DBA1', 'dba_role');
exec ganrole_user('DBA2', 'dba_role');
exec ganrole_nhanvien(551,555, 'thanhtra_role');
exec ganrole_nhanvien(556,605, 'nvcsyt_role');
exec ganrole_nhanvien(1,500, 'ybacsi_role');
exec ganrole_nhanvien(501,550, 'nghiencuu_role');
exec ganrole_benhnhan(1,10000, 'benhnhan_role');