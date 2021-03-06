
/****** Object:  Table [dbo].[Chiller_Chiller_Info]    Script Date: 3/4/2017 6:02:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chiller](
	[chiller_id] [int] NOT NULL,
	[facility_id] [int] NOT NULL,
	[creator] [varchar](50) NULL,
	[creation_time] [datetime] NULL,
	[edit_time] [datetime] NULL,
	[status] [nvarchar](255) NULL,
	[total_system_power_kw] [float] NULL,
	[cooling_load_RT] [float] NULL,
	[system_efficiency_kwRT] [float] NULL,
	[system_heat_balance] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[chiller_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chiller_Equipment]    Script Date: 3/4/2017 6:02:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chiller_Equipment](
	[chiller_equipment_id] [int] IDENTITY(1,1) NOT NULL,
	[creator] [varchar](50) NULL,
	[creation_time] [datetime] NULL,
	[edit_time] [datetime] NULL,
	[status] [nvarchar](255) NULL,
	[etype] [nvarchar](255) NOT NULL,
	[ename] [nvarchar](255) NOT NULL,
	[facility_id] [int] NOT NULL,
	[locationx] [float] NOT NULL,
	[locationy] [float] NOT NULL,
	[manufacturer] [varchar](50) NULL,
	[model] [varchar](50) NULL,
	[description] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[chiller_equipment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chiller_Equipment_Status_Profile]    Script Date: 3/4/2017 6:02:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chiller_Equipment_Profile](
	[chiller_equipment_profile_id] [int] NOT NULL,
	[equipment_id] [int] NOT NULL,
	[creator] [varchar](50) NULL,
	[creation_time] [datetime] NULL,
	[edit_time] [datetime] NULL,
	[status] [nvarchar](255) NULL,
	[e_status] [nvarchar](255) NULL,
	[energy] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[chiller_equipment_profile_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chiller_Facility]    Script Date: 3/4/2017 6:02:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chiller_Facility](
	[chiller_facility_id] [int] IDENTITY(1,1) NOT NULL,
	[creator] [varchar](50) NULL,
	[creation_time] [datetime] NULL,
	[edit_time] [datetime] NULL,
	[status] [nvarchar](255) NULL,
	[company_id] [int] NOT NULL,
	facility_name  [varchar](50) NULL,
	[annual_energy_use] [float] NULL,
	[flength] [float] NULL,
	[fwidth] [float] NULL,
	[fheight] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[chiller_facility_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chiller_Profile]    Script Date: 3/4/2017 6:02:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chiller_Profile](
	[chiller_profile_id] [int] NOT NULL,
	[chiller_id] [int] NOT NULL,
	[creator] [varchar](50) NULL,
	[creation_time] [datetime] NULL,
	[edit_time] [datetime] NULL,
	[status] [nvarchar](255) NULL,
	[starttime] [datetime] NULL,
	[endtime] [datetime] NULL,
	[chilled_water_pump_power_kw] [float] NULL,
	[CHWS_temp_C] [float] NULL,
	[CHWR_temp_C] [float] NULL,
	[cooling_coil_fan_power_kw] [float] NULL,
	[CHWFR_m3hr] [float] NULL,
	[cooling_air_flow_rate_m3hr] [float] NULL,
	[cooling_air_flow_volume_m3] [float] NULL,
	[header_CWFR_m3hr] [float] NULL,
	[header_CWR_temp_C] [float] NULL,
	[cooling_air_outlet_temp_C] [float] NULL,
	[cooling_air_inlet_temp_C] [float] NULL,
	[header_CWS_temp_C] [float] NULL,
	[condenser_pump_power_kw] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[chiller_profile_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Chiller]  WITH CHECK ADD FOREIGN KEY([facility_id])
REFERENCES [dbo].[Chiller_Facility] ([chiller_facility_id])
GO
ALTER TABLE [dbo].[Chiller_Equipment]  WITH CHECK ADD FOREIGN KEY([facility_id])
REFERENCES [dbo].[Chiller_Facility] ([chiller_facility_id])
GO
ALTER TABLE [dbo].[Chiller_Equipment_Profile]  WITH CHECK ADD FOREIGN KEY([equipment_id])
REFERENCES [dbo].[Chiller_Equipment] ([chiller_equipment_id])
GO
ALTER TABLE [dbo].[Chiller_Facility]  WITH CHECK ADD FOREIGN KEY([company_id])
REFERENCES [dbo].[Company] ([company_id])
GO
ALTER TABLE [dbo].[Chiller_Profile]  WITH CHECK ADD FOREIGN KEY([chiller_id])
REFERENCES [dbo].[Chiller] ([chiller_id])
GO
