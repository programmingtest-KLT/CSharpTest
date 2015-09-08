CREATE TABLE [dbo].[PressureHistory]
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	PRESSURE int,
	TIME_RECORDED as DateTime
)
