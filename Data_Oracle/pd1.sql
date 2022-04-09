-- 1. Xem danh sách ng??i dùng trong h? th?ng.
SELECT * FROM Dba_users;
SELECT * FROM ALL_USERS ;

--2. Thông tin v? quy?n (privileges) c?a m?i user/ role trên các ??i t??ng d? li?u.
SELECT * FROM  USER_TAB_PRIVS WHERE TABLE_NAME = 'BENHNHAN' OR  TABLE_NAME = 'NHANVIEN' ;
SELECT * FROM USER_TAB_PRIVS;


-- xem quyen cua mot role 
  SELECT *  
  FROM ROLE_TAB_PRIVS
  WHERE ROLE = 'NHANVIEN_ROLE';
  
-- xem cac bang hien co trong he thong

SELECT owner, table_name FROM all_tables
where owner = 'HETHONG';

-- xem cac cot trong bang
SELECT column_name
FROM user_tab_cols
WHERE table_name = 'NHANVIEN';

-- xem cac quyen tren bang cua mot nguoi dung 
select * from dba_tab_privs
where grantee = '';

--xem cac quyen tren cot cua nguoi dung 
select * from dba_col_privs 
where grantee = '';

-- 3. T?o user
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
        lv_stmt:='DROP USER ' ||user_name ||' CASCADE';
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


-- 4 xóa user
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



-- 5.edit user
ALTER USER USER_TEMP_02 IDENTIFIED BY USER_TEMP_02;


-- 6. t?o role
CREATE OR REPLACE PROCEDURE proc_createRole(
    ip_rolename IN NVARCHAR2,
    ip_identify IN NVARCHAR2)
IS
role_name nvarchar2(20):= ip_rolename;
identify nvarchar2(20):= ip_identify;
exec_commander varchar(1000);
    BEGIN
        exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"= TRUE';
        EXECUTE IMMEDIATE(exec_commander);
        
        exec_commander:='CREATE ROLE '||role_name ||' IDENTIFIED BY '||identify;
        EXECUTE IMMEDIATE(exec_commander);

          exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"= FALSE';
        EXECUTE IMMEDIATE(exec_commander);
    COMMIT;
    END proc_createRole;

-- 7. xóa role
CREATE OR REPLACE PROCEDURE proc_deleteRole(
ip_rolename IN NVARCHAR2)
IS 
role_name NVARCHAR2(20):=ip_rolename;
exec_commander varchar(1000);
BEGIN
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
      EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='DROP ROLE '|| role_name;
    EXECUTE IMMEDIATE (exec_commander);
    
      exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
      EXECUTE IMMEDIATE(exec_commander);
COMMIT;
END proc_deleteRole;

-- 8 cap role cho user 
CREATE OR REPLACE PROCEDURE proc_grantRole(
    ip_rolename IN VARCHAR2,
    ip_username IN VARCHAR2)
IS
role_name varchar2(20):= ip_rolename;
user_name nvarchar2(20):= ip_username;
exec_commander varchar(1000);
    BEGIN
        exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"= TRUE';
        EXECUTE IMMEDIATE(exec_commander);
        
        exec_commander:='grant  '||role_name ||' to '||user_name;
        EXECUTE IMMEDIATE(exec_commander);

          exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"= FALSE';
        EXECUTE IMMEDIATE(exec_commander);
    COMMIT;
    END proc_grantRole;
    
    