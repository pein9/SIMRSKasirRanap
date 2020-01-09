Imports Devart.Data.MySql
Imports Pein
Public Class Radiologi
    Dim Connect As New ConnectionSQL
    Dim Exc As New BaseExceptionsHandler
    Public Property ToLabRadioLogi As Double = 0

#Region "QUERY"
    Public Function SelectNoDaftar() As String
        Return <SQL>
               SELECT
                    t_registrasirawatinap.noDaftar,
                    t_tindakanradiologiranap.noRegistrasiRadiologiRanap,
                    t_tindakanradiologiranap.tglTindakanRadiologiRanap,
                    t_tindakanradiologiranap.statusPembayaran
                FROM
                    t_registrasirawatinap
                INNER JOIN t_registrasiradiologiranap ON t_registrasirawatinap.noDaftar = t_registrasiradiologiranap.noDaftar
                INNER JOIN t_tindakanradiologiranap ON t_registrasiradiologiranap.noRegistrasiRadiologiRanap = t_tindakanradiologiranap.noRegistrasiRadiologiRanap
                WHERE t_registrasirawatinap.noDaftar=@noDaftar
                GROUP BY
                    t_registrasirawatinap.noDaftar
               </SQL>
    End Function
    Public Function SelectRadiologiRelationScript() As String
        Return <SQL>
            SELECT
                t_tindakanradiologiranap.noRegistrasiRadiologiRanap,
                t_detailtindakanradiologiranap.tindakan,
                t_detailtindakanradiologiranap.tarif,
                t_detailtindakanradiologiranap.jumlahTindakan,
                t_detailtindakanradiologiranap.totalTarif,
                t_tenagamedis2.namapetugasMedis
            FROM
                t_detailtindakanradiologiranap
            INNER JOIN t_tindakanradiologiranap ON t_tindakanradiologiranap.noTindakanRadiologiRanap = t_detailtindakanradiologiranap.noTindakanRadiologiRanap
            INNER JOIN t_tenagamedis2 ON t_tenagamedis2.kdPetugasMedis = t_detailtindakanradiologiranap.kdTenagaMedis
                </SQL>
    End Function
    Public Function UpdateStatusRadiologiRanap() As String
        Return <SQL>
            UPDATE  t_tindakanradiologiranap
			   SET t_tindakanradiologiranap.statusPembayaran = @statusPembayaran
			WHERE  t_tindakanradiologiranap.noRegistrasiRadiologiRanap = @noRegistrasiRadiologiRanap
               </SQL>
    End Function
    Public Function SelectNoRadiologiScript() As String
        Return <SQL>
            SELECT
                t_tindakanradiologiranap.noRegistrasiRadiologiRanap
            FROM
                t_tindakanradiologiranap
            WHERE
                t_tindakanradiologiranap.noRegistrasiRadiologiRanap = @noRegistrasiRadiologiRanap
            GROUP BY
                t_tindakanradiologiranap.noRegistrasiRadiologiRanap
                </SQL>
    End Function
#End Region
    Public Function DataRadiologiPasien(ByVal NoDaft As String) As DataSet
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

                    CType(New MySqlDataAdapter(SelectRadiologiRelationScript, cn), MySqlDataAdapter).Fill(ds, "Radio")

                    ds.Tables("Pasien").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ' ds.Tables("Radio").Columns("noDaftar").ColumnMapping = MappingType.Hidden
                    ' ds.Tables("Radio").Columns("noTindakanPenunjangRanap").ColumnMapping = MappingType.Hidden

                    ds.Tables("Pasien").Columns("noRegistrasiRadiologiRanap").ColumnName = "No.Registrasi Radiologi"
                    ds.Tables("Pasien").Columns("tglTindakanRadiologiRanap").ColumnName = "Tanggal Tindakan"
                    ds.Tables("Pasien").Columns("statusPembayaran").ColumnName = "Status"



                    ds.Tables("Radio").Columns("noRegistrasiRadiologiRanap").ColumnName = "No.Registrasi Radiologi"

                    ds.Tables("Radio").Columns("tindakan").ColumnName = "Tindakan"
                    ds.Tables("Radio").Columns("tarif").ColumnName = "Tarif"
                    ds.Tables("Radio").Columns("jumlahTindakan").ColumnName = "Jumlah Tindakan"
                    ds.Tables("Radio").Columns("totalTarif").ColumnName = "TotalTarif"
                    ds.Tables("Radio").Columns("namapetugasMedis").ColumnName = "Petugas"

                    ds.Relations.Add("1", ds.Tables("Pasien").Columns("No.Registrasi Radiologi"), ds.Tables("Radio").Columns("No.Registrasi Radiologi"), False)


                    'ds.Relations.Add()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

        Return ds

    End Function

End Class
