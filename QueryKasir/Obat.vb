Imports Devart.Data.MySql
Imports Pein
Public Class Obat
    Dim Connect As New ConnectionSQL
    Dim Exc As New BaseExceptionsHandler
    Public Property ToObatPasien As Double = 0

#Region "QUERY"
    Protected Function SelectNoDaftarObat() As String
        Return <SQL>
            SELECT
                simrs.t_registrasirawatinap.noDaftar,
                farmasi2.t_penjualanobatranap.noPenjualanObatRanap,
                farmasi2.t_penjualanobatranap.tglPenjualanObatRanap,
                farmasi2.t_penjualanobatranap.totalAkhirPenjualanRanap,
                farmasi2.t_penjualanobatranap.statusPembayaran
            FROM
                simrs.t_registrasirawatinap
            INNER JOIN farmasi2.t_penjualanobatranap ON simrs.t_registrasirawatinap.noDaftar = farmasi2.t_penjualanobatranap.noDaftar
            WHERE simrs.t_registrasirawatinap.noDaftar = @noDaftar
                </SQL>
    End Function
    Public Function SelectObatRelationScript() As String
        Return <SQL>
           SELECT
                farmasi2.t_penjualanobatranap.noDaftar,
                farmasi2.t_penjualanobatranap.noPenjualanObatRanap,
                farmasi2.t_detailpenjualanobatranap.kdObat,
                farmasi2.t_detailpenjualanobatranap.namaObat,
                farmasi2.t_detailpenjualanobatranap.harga,
                (farmasi2.t_detailpenjualanobatranap.diberikanKronis + farmasi2.t_detailpenjualanobatranap.diberikanNonKronis) AS JumlahItem,
				farmasi2.t_detailpenjualanobatranap.subTotalPenjualan
            FROM
                farmasi2.t_penjualanobatranap
            INNER JOIN farmasi2.t_detailpenjualanobatranap ON farmasi2.t_penjualanobatranap.noPenjualanObatRanap = farmasi2.t_detailpenjualanobatranap.noPenjualanObatRanap       </SQL>
    End Function
    Public Function UpdateStatusObatRanap() As String
        Return <SQL>
            UPDATE  farmasi2.t_penjualanobatranap
			   SET farmasi2.t_penjualanobatranap.statusPembayaran = @statusPembayaran,
                    farmasi2.t_penjualanobatranap.tglPembayaran = @tglPembayaran
			WHERE  farmasi2.t_penjualanobatranap.noPenjualanObatRanap = @noPenjualanObatRanap
               </SQL>
    End Function
    Public Function SelectNoObatPenjualanScript() As String
        Return <SQL>
            SELECT
                farmasi2.t_penjualanobatranap.noPenjualanObatRanap
            FROM
                farmasi2.t_penjualanobatranap
            WHERE
                farmasi2.t_penjualanobatranap.noPenjualanObatRanap = @noPenjualanObatRanap
            GROUP BY
                farmasi2.t_penjualanobatranap.noPenjualanObatRanap
                </SQL>
    End Function
#End Region
    Public Function DataObatPasien(ByVal NoDaft As String) As DataSet
        ' Dim dt As New DataTable
        Dim ds As New DataSet()
        Using cn As New MySqlConnection With {.ConnectionString = Connect.con}
            Using cmd As New MySqlCommand With {.Connection = cn}

                cmd.CommandText = SelectNoDaftarObat()
                cmd.Parameters.AddWithValue("@noDaftar", NoDaft)
                Dim da As New MySqlDataAdapter(cmd)

                Try
                    'ds = New DataSet()
                    cn.Open()
                    da.Fill(ds, "Pasien")

                    CType(New MySqlDataAdapter(SelectObatRelationScript, cn), MySqlDataAdapter).Fill(ds, "Obat")
                    ' CType(New MySqlDataAdapter(SelectPenunjangRelationScript, cn), MySqlDataAdapter).Fill(ds, "Penunjang")

                    ds.Tables("Pasien").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ds.Tables("Obat").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ds.Tables("Obat").Columns("kdObat").ColumnMapping = MappingType.Hidden

                    ds.Tables("Pasien").Columns("noPenjualanObatRanap").ColumnName = "No.Penjualan Obat"
                    ds.Tables("Pasien").Columns("tglPenjualanObatRanap").ColumnName = "Tanggal Penjualan"
                    ds.Tables("Pasien").Columns("totalAkhirPenjualanRanap").ColumnName = "Total Akhir"
                    ds.Tables("Pasien").Columns("statusPembayaran").ColumnName = "Status"

                    ds.Tables("Obat").Columns("noPenjualanObatRanap").ColumnName = "No.Penjualan Obat"
                    ds.Tables("Obat").Columns("kdObat").ColumnName = "Kode Obat"
                    ds.Tables("Obat").Columns("namaObat").ColumnName = "Nama Obat"

                    ds.Tables("Obat").Columns("harga").ColumnName = "Harga"
                    ds.Tables("Obat").Columns("JumlahItem").ColumnName = "Jumlah Obat"
                    ds.Tables("Obat").Columns("subTotalPenjualan").ColumnName = "Subtotal Jual"

                    ds.Relations.Add("1", ds.Tables("Pasien").Columns("No.Penjualan Obat"), ds.Tables("Obat").Columns("No.Penjualan Obat"), False)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

        Return ds

    End Function
End Class
