
SELECT * FROM dbo.[Login]

INSERT INTO dbo.[Login] (UserName,[password])
VALUES ('Admin','11111');
DELETE FROM dbo.[Login]
WHERE Id = '4';