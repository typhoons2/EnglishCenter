USE [QL_ANHNGU]
GO
/****** Object:  StoredProcedure [dbo].[LOP_HOC_BY_TIME]    Script Date: 6/8/2016 10:23:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[LOP_HOC_BY_TIME] (@ThoiGianBD as SmallDateTime, @ThoiGianKT as SmallDateTime)
AS
SELECT * FROM LOP_HOC Where ThoiGianKT>= @ThoiGianBD and NgayKhaiGiang <= @ThoiGianKT