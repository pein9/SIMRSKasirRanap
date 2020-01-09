Imports Devart.Data.MySql
Imports Pein
Public Class Penunjang
    Dim Connect As New ConnectionSQL
    Dim Exc As New BaseExceptionsHandler
    Public Property ToLabTarifTindakan As Double
#Region "Query"
    Protected Function SelectNoDaftar() As String
        Return <SQL>
            SELECT
                t_registrasipenunjangranap.noDaftar,
                t_tindakanpenunjangranap.noRegistrasiPenunjangRanap,
                t_tindakanpenunjangranap.tglTindakanPenunjangRanap,
                t_tindakanpenunjangranap.statusPembayaran
            FROM
                t_tindakanpenunjangranap
            INNER JOIN t_registrasipenunjangranap ON t_registrasipenunjangranap.noRegistrasiPenunjangRanap = t_tindakanpenunjangranap.noRegistrasiPenunjangRanap
            WHERE t_registrasipenunjangranap.noDaftar=@noDaftar
            GROUP BY
                t_registrasipenunjangranap.noDaftar
               </SQL>
    End Function
    Public Function SelectPenunjangRelationScript() As String
        Return <SQL>
        SELECT
            t_registrasipenunjangranap.noDaftar,
            t_tindakanpenunjangranap.noRegistrasiPenunjangRanap,
            t_detailtindakanpenunjangranap.noTindakanPenunjangRanap,
            t_detailtindakanpenunjangranap.tindakan,
            t_detailtindakanpenunjangranap.tarif,
            t_detailtindakanpenunjangranap.jumlahTindakan,
            t_detailtindakanpenunjangranap.totalTarif,
            t_tenagamedis2.namapetugasMedis
        FROM
            t_tindakanpenunjangranap
        INNER JOIN t_registrasipenunjangranap ON t_registrasipenunjangranap.noRegistrasiPenunjangRanap = t_tindakanpenunjangranap.noRegistrasiPenunjangRanap
        INNER JOIN t_detailtindakanpenunjangranap ON t_tindakanpenunjangranap.noTindakanPenunjangRanap = t_detailtindakanpenunjangranap.noTindakanPenunjangRanap
        INNER JOIN t_tenagamedis2 ON t_detailtindakanpenunjangranap.kdTenagaMedis = t_tenagamedis2.kdPetugasMedis
        GROUP BY
            t_registrasipenunjangranap.noDaftar
               </SQL>
    End Function

    'Untuk Update Status
    Public Function SelectNoPenunjang() As String
        Return <SQL>
            SELECT
                t_tindakanpenunjangranap.noRegistrasiPenunjangRanap,
                t_tindakanpenunjangranap.tglTindakanPenunjangRanap,
                t_tindakanpenunjangranap.statusPembayaran
            FROM
                t_tindakanpenunjangranap
            INNER JOIN t_registrasipenunjangranap ON t_registrasipenunjangranap.noRegistrasiPenunjangRanap = t_tindakanpenunjangranap.noRegistrasiPenunjangRanap
            WHERE t_tindakanpenunjangranap.noRegistrasiPenunjangRanap = @noRegistrasiPenunjangRanap
            GROUP BY
                t_registrasipenunjangranap.noDaftar
               </SQL>
    End Function
    Public Function UpdateStatusLabPasienRanap() As String
        Return <SQL>
            UPDATE  t_tindakanpenunjangranap
			   SET t_tindakanpenunjangranap.statusPembayaran = @statusPembayaran
			WHERE  t_tindakanpenunjangranap.noRegistrasiPenunjangRanap  = @noRegistrasiPenunjangRanap
               </SQL>
    End Function

    'Total Tarif Lunas
    Public Function GetLabTotalTarifLunas() As String
        Return <SQL>
            SELECT
                Sum(t_detailtindakanpenunjangranap.totalTarif)
            FROM
                t_tindakanpenunjangranap
            INNER JOIN t_registrasipenunjangranap ON t_registrasipenunjangranap.noRegistrasiPenunjangRanap = t_tindakanpenunjangranap.noRegistrasiPenunjangRanap
            INNER JOIN t_detailtindakanpenunjangranap ON t_tindakanpenunjangranap.noTindakanPenunjangRanap = t_detailtindakanpenunjangranap.noTindakanPenunjangRanap
            WHERE
                t_tindakanpenunjangranap.statusPembayaran = 'LUNAS' AND t_registrasipenunjangranap.noDaftar=@noDaftar
            GROUP BY
                t_registrasipenunjangranap.noDaftar
               </SQL>
    End Function
    Public Function AmbilNoTarifLab(ByRef nDaftar As String) As String
        Exc.mHasException = False

        Dim selectStatement As String = GetLabTotalTarifLunas()

        Try
            Using cn = New MySqlConnection(Connect.con)
                Using cmd = New MySqlCommand() With {.Connection = cn, .CommandText = selectStatement}
                    cmd.Parameters.AddWithValue("@noDaftar", nDaftar)
                    cn.Open()

                    Dim reader As MySqlDataReader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()

                        nDaftar = nDaftar
                        ToLabTarifTindakan = reader.GetDouble(0)
                    End If
                End Using
            End Using
        Catch ex As Exception
            Exc.mHasException = True
            Exc.mLastException = ex
        End Try

        Return Exc.IsSuccessFul
    End Function
#End Region
    Public Function DataLabPasien(ByVal NoDaft As String) As DataSet
        ' Dim dt As New DataTable
        Dim ds As New DataSet()
        Using cn As New MySqlConnection With {.ConnectionString = Connect.con}
            Using cmd As New MySqlCommand With {.Connection = cn}

                cmd.CommandText = SelectNoDaftar()
                cmd.Parameters.AddWithValue("@noDaftar", NoDaft)
                Dim da As New MySqlDataAdapter(cmd)

                Try
                    'ds = New DataSet()
                    cn.Open()
                    da.Fill(ds, "Pasien")

                    CType(New MySqlDataAdapter(SelectPenunjangRelationScript, cn), MySqlDataAdapter).Fill(ds, "Penunjang")

                    ds.Tables("Pasien").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ds.Tables("Penunjang").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ds.Tables("Penunjang").Columns("noTindakanPenunjangRanap").ColumnMapping = MappingType.Hidden

                    ds.Tables("Pasien").Columns("noRegistrasiPenunjangRanap").ColumnName = "No.Registrasi Laboratorium"
                    ds.Tables("Pasien").Columns("tglTindakanPenunjangRanap").ColumnName = "Tanggal Tindakan"
                    ds.Tables("Pasien").Columns("statusPembayaran").ColumnName = "Status"


                    ds.Tables("Penunjang").Columns("noDaftar").ColumnName = "No.Registrasi"
                    ds.Tables("Penunjang").Columns("noRegistrasiPenunjangRanap").ColumnName = "No.Registrasi Laboratorium"

                    ds.Tables("Penunjang").Columns("tindakan").ColumnName = "Tindakan"
                    ds.Tables("Penunjang").Columns("tarif").ColumnName = "Tarif"
                    ds.Tables("Penunjang").Columns("jumlahTindakan").ColumnName = "Jumlah Tindakan"
                    ds.Tables("Penunjang").Columns("totalTarif").ColumnName = "TotalTarif"
                    ds.Tables("Penunjang").Columns("namapetugasMedis").ColumnName = "Petugas"

                    ds.Relations.Add("1", ds.Tables("Pasien").Columns("No.Registrasi Laboratorium"), ds.Tables("Penunjang").Columns("No.Registrasi Laboratorium"), False)


                    'ds.Relations.Add()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

        Return ds

    End Function
End Class
