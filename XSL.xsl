<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="ResultDataBase">
    <HTML>
      <BODY>
        <p>
          <H2>Список студентів</H2>
        </p>
      </BODY>
      <BODY>
        <TABLE BORDER="2">
          <TR>
            <TD>
              <b>Прізвище</b>
            </TD>
            <TD>
              <b>Ім'я</b>
            </TD>
            <TD>
              <b>Факультет</b>
            </TD>
            <TD>
              <b>Кафедра</b>
            </TD>
            <TD>
              <b>Група</b>
            </TD>
            <TD>
              <b>Середній рейтинг</b>
            </TD>
            <TD>
              <b>Кімната</b>
            </TD>
          </TR>
          <xsl:apply-templates select="Student"/>
        </TABLE>
      </BODY>
    </HTML>
  </xsl:template>
  <xsl:template match="Student">
    <TR>
      <TD>
        <b>
          <xsl:value-of select="@SURNAME"/>
        </b>
      </TD>
      <TD>
        <xsl:value-of select="@NAME"/>
      </TD>
      <TD>
        <xsl:value-of select="@FACULTY"/>
      </TD>
      <TD>
        <xsl:value-of select="@DEPARTMENT"/>
      </TD>
      <TD>
        <xsl:value-of select="@GROUP"/>
      </TD>
      <TD>
        <xsl:value-of select="@RATING"/>
      </TD>
      <TD>
        <xsl:value-of select="@ROOM"/>
      </TD>
    </TR>
  </xsl:template>
</xsl:stylesheet>
